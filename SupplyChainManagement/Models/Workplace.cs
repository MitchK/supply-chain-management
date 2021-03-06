﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SupplyChainManagement.Data;

namespace SupplyChainManagement.Models
{
    public class Workplace 
    {
        /// <summary>
        /// Work place id
        /// </summary>
        public int Id;

        /// <summary>
        /// Job description
        /// </summary>
        public String JobDescription;

        /// <summary>
        /// Labor costs of the first shift of the day, 12am - 8am (8 hours)
        /// </summary>
        public double LaborCostsFirstShift;

        /// <summary>
        /// Labor costs of the second shift of the day, 8am - 4pm (8 hours)
        /// </summary>
        public double LaborCostsSecondShift;

        /// <summary>
        /// Labor costs of the third shift of the day 4pm - 12am (8 hours)
        /// </summary>
        public double LaborCostsThirdShift;

        /// <summary>
        /// Labor costs for overtime
        /// </summary>
        public double LaborCostsOvertime;

        /// <summary>
        /// Machine costs during production
        /// </summary>

        public double ProductiveMachineCosts;

        /// <summary>
        /// Machine costs in idle
        /// </summary>
        public double IdleMachineCosts;

        /// <summary>
        /// All jobs that is done by this workplace
        /// </summary>
        public List<ItemJob> Jobs = new List<ItemJob>();

        public override string ToString()
        {
            return "Workplace #" + this.Id + " with " + this.Jobs.Count + " jobs";
        }
    }
}
