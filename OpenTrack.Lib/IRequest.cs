﻿using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace OpenTrack
{
    /// <summary>
    /// A base class to use for requests to the OpenTrack API and handles deserializing the result to type T.
    /// </summary>
    public abstract class IRequest<T>
    {
        public String EnterpriseCode { get; private set; }

        public String DealerCode { get; private set; }

        public String ServerName { get; private set; }

        public IRequest(String EnterpriseCode, String DealerCode, String ServerName)
        {
            this.EnterpriseCode = EnterpriseCode;
            this.DealerCode = DealerCode;
            this.ServerName = ServerName;
        }

        /// <summary>
        /// A property representing the XML content of a specific request.
        /// </summary>
        internal abstract XElement Elements { get; }

        /// <summary>
        /// Returns the XML request as a string in the correct format.
        /// </summary>
        internal virtual String XML
        {
            get { return RemoveEmptyElements(this.Elements).ToString(); }
        }

        /// <summary>
        /// Process the xml response from the web service.
        /// </summary>
        internal virtual T ProcessResponse(XmlElement xml)
        {
            using (var reader = XmlReader.Create(new StringReader(xml.OuterXml)))
            {
                return (T)new XmlSerializer(typeof(T)).Deserialize(reader);
            }
        }

        /// <summary>
        /// Removes empty elements from the XML (i.e. <Data />)
        /// </summary>
        private XElement RemoveEmptyElements(XElement xml)
        {
            var query = xml.Descendants().Where(c => !c.HasAttributes && c.IsEmpty);

            while (query.Any())
            {
                query.Remove();
            }

            return xml;
        }

        /// <summary>
        /// The text content of the 'dealer' elements, specific to a dealership for the request.
        /// </summary>
        internal virtual XElement Dealer
        {
            get
            {
                return new XElement("Dealer",
                    new XElement("EnterpriseCode", this.EnterpriseCode),
                    new XElement("CompanyNumber", this.DealerCode),
                    new XElement("ServerName", this.ServerName)
                    );
            }
        }
    }
}