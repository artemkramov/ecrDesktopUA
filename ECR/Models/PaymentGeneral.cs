using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace ECR.Models
{

    /// <summary>
    /// Class for sending of the general payment
    /// </summary>
    class PaymentGeneral : Entity
    {

        /// <summary>
        /// Product code
        /// </summary>
        private ulong code;

        /// <summary>
        /// Product name
        /// </summary>
        private string name;

        /// <summary>
        /// Product quantity
        /// </summary>
        private float qty;

        /// <summary>
        /// Product price
        /// </summary>
        private float price;

        /// <summary>
        /// Product sum = qty * price
        /// </summary>
        private float sum;

        /// <summary>
        /// Product department
        /// </summary>
        private int dep;

        /// <summary>
        /// Product group
        /// </summary>
        private int grp;

        /// <summary>
        /// Product tax
        /// </summary>
        private int tax;

        /// <summary>
        /// Payment type
        /// </summary>
        private int paymentNo;

        /// <summary>
        /// Payment sum
        /// </summary>
        private float paymentSum;

        /// <summary>
        /// Forms JSON string for server POST query 
        /// </summary>
        /// <returns></returns>
        public override string ToJson()
        {
            dynamic pData = new ExpandoObject();
            dynamic sData = new ExpandoObject();

            dynamic innerData = new ExpandoObject();
            innerData.code = this.code;
            innerData.name = this.name;
            innerData.qty = this.qty;
            innerData.price = this.price;
            innerData.sum = this.sum;
            innerData.dep = this.dep;
            innerData.grp = this.grp;
            innerData.tax = this.tax;
            sData.S = innerData;

            dynamic paymentData = new ExpandoObject();
            paymentData.no = this.paymentNo;
            paymentData.sum = this.paymentSum;
            pData.P = paymentData;

            dynamic[] fData = new dynamic[2] { sData, pData };

            dynamic generalData = new ExpandoObject();
            generalData.F = fData;

            return JsonConvert.SerializeObject(generalData); 
        }

        /// <summary>
        /// Read all data
        /// </summary>
        /// <param name="data"></param>
        public PaymentGeneral(dynamic data)
        {
            this.code = data.Code;
            this.name = data.Name;
            this.qty = this.ConvertQuantity(data.Count);
            this.price = data.Price;
            this.sum = data.Sum;
            this.dep = data.Department;
            this.grp = data.Group;
            this.tax = data.Tax;
            this.paymentSum = data.PaymentSum;
            this.paymentNo = data.PaymentType;

        }

        /// <summary>
        /// Convert quantity back to float view
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        private float ConvertQuantity(float quantity)
        {
            return (float)Math.Round(quantity, 3);
        }

    }
}
