using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForFactory.Entity
{ 
    public class SalesOrder
    {
        /// <summary>
        /// 
        /// </summary>
        public long soNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string orderLineId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string lineStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string modelNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string modelDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int orderedQuantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int shippedQuantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string orderedLocation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string orgId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string custPoNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string customerNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string customerName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string shipToLocation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string actualShipmentDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string salespresonNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string salesperson { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int vendorNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string vendorName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string requestDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string promiseDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string soInputDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string itemCategory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string salesChannel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int serialVersionUID { get; set; }
    }
}
