﻿using System;

using NUnit.Framework;

using System.Diagnostics;
using System.Collections.Generic;

using System.Linq;

using SupplyChainManagement;
using SupplyChainManagement.Data;
using SupplyChainManagement.Models;
using SupplyChainManagement.Models.ItemManagement;
using SupplyChainManagement.Services;
using SupplyChainManagement.Util;

namespace SupplyChainManagementTest
{
    public class DataSourceMockTest
    {
        
        [TestCase]
        public void ReferenceTest() { 
            
            DataSource ds = new DataSourceMock();
            Assert.AreSame(ds.Items[24], ds.Items[24]);
        }


        [TestCase]
        public void P1BillOfMaterialShouldBeCorrect()
        {
            DataSource ds = new DataSourceMock();
            var billOfMaterial = BillOfMaterialUtil.CreateBillOfMaterial(ds.Items[1] as Product);

            // Produced item 4 must have 34 distinct items
            Assert.AreNotEqual(billOfMaterial.Count, 0);
            Assert.AreEqual(34, billOfMaterial.Count);

            Assert.AreEqual(1, billOfMaterial[ds.Items[4]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[7]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[10]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[13]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[16]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[17]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[18]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[26]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[49]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[50]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[51]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[21]]);
            Assert.AreEqual(7, billOfMaterial[ds.Items[24]]);
            Assert.AreEqual(4, billOfMaterial[ds.Items[25]]);
            Assert.AreEqual(2, billOfMaterial[ds.Items[27]]);
            Assert.AreEqual(4, billOfMaterial[ds.Items[28]]);
            Assert.AreEqual(3, billOfMaterial[ds.Items[32]]);
            Assert.AreEqual(4, billOfMaterial[ds.Items[35]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[36]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[37]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[38]]);
            Assert.AreEqual(2, billOfMaterial[ds.Items[39]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[40]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[41]]);
            Assert.AreEqual(2, billOfMaterial[ds.Items[42]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[43]]);
            Assert.AreEqual(3, billOfMaterial[ds.Items[44]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[45]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[46]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[47]]);
            Assert.AreEqual(2, billOfMaterial[ds.Items[48]]);
            Assert.AreEqual(2, billOfMaterial[ds.Items[52]]);
            Assert.AreEqual(72, billOfMaterial[ds.Items[53]]);
            Assert.AreEqual(2, billOfMaterial[ds.Items[59]]);
        }

        [TestCase]
        public void P2BillOfMaterialShouldBeCorrect()
        {
            DataSource ds = new DataSourceMock();
            var billOfMaterial = BillOfMaterialUtil.CreateBillOfMaterial(ds.Items[2] as Product);

            // Product 2 must have 34 distinct items
            Assert.AreNotEqual(billOfMaterial.Count, 0);
            Assert.AreEqual(34, billOfMaterial.Count);

            Assert.AreEqual(1, billOfMaterial[ds.Items[5]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[8]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[11]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[14]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[16]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[17]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[19]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[26]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[54]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[55]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[56]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[22]]);
            Assert.AreEqual(7, billOfMaterial[ds.Items[24]]);
            Assert.AreEqual(4, billOfMaterial[ds.Items[25]]);
            Assert.AreEqual(2, billOfMaterial[ds.Items[27]]);
            Assert.AreEqual(5, billOfMaterial[ds.Items[28]]);
            Assert.AreEqual(3, billOfMaterial[ds.Items[32]]);
            Assert.AreEqual(4, billOfMaterial[ds.Items[35]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[36]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[37]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[38]]);
            Assert.AreEqual(2, billOfMaterial[ds.Items[39]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[40]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[41]]);
            Assert.AreEqual(2, billOfMaterial[ds.Items[42]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[43]]);
            Assert.AreEqual(3, billOfMaterial[ds.Items[44]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[45]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[46]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[5]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[47]]);
            Assert.AreEqual(2, billOfMaterial[ds.Items[48]]);
            Assert.AreEqual(2, billOfMaterial[ds.Items[57]]);
            Assert.AreEqual(72, billOfMaterial[ds.Items[58]]);
            Assert.AreEqual(2, billOfMaterial[ds.Items[59]]);

        }

        [TestCase]
        public void P3BillOfMaterialShouldBeCorrect()
        {
            DataSource ds = new DataSourceMock();
            var billOfMaterial = BillOfMaterialUtil.CreateBillOfMaterial(ds.Items[3] as Product);

            // Product 3 must have 34 distinct items
            Assert.AreNotEqual(billOfMaterial.Count, 0);
            Assert.AreEqual(34, billOfMaterial.Count);

            Assert.AreEqual(1, billOfMaterial[ds.Items[6]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[9]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[12]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[15]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[16]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[17]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[20]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[26]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[29]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[30]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[31]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[23]]);
            Assert.AreEqual(7, billOfMaterial[ds.Items[24]]);
            Assert.AreEqual(4, billOfMaterial[ds.Items[25]]);
            Assert.AreEqual(2, billOfMaterial[ds.Items[27]]);
            Assert.AreEqual(6, billOfMaterial[ds.Items[28]]);
            Assert.AreEqual(3, billOfMaterial[ds.Items[32]]);
            Assert.AreEqual(2, billOfMaterial[ds.Items[33]]);
            Assert.AreEqual(72, billOfMaterial[ds.Items[34]]);
            Assert.AreEqual(4, billOfMaterial[ds.Items[35]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[36]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[37]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[38]]);
            Assert.AreEqual(2, billOfMaterial[ds.Items[39]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[40]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[41]]);
            Assert.AreEqual(2, billOfMaterial[ds.Items[42]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[43]]);
            Assert.AreEqual(3, billOfMaterial[ds.Items[44]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[45]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[46]]);
            Assert.AreEqual(1, billOfMaterial[ds.Items[47]]);
            Assert.AreEqual(2, billOfMaterial[ds.Items[48]]);
            Assert.AreEqual(2, billOfMaterial[ds.Items[59]]);
        }


        [TestCase]
        public void HasCorrectTotalStock() {
            DataSource ds = new DataSourceMock();
            var expectedTotalStockValue = 289555.0;

            var totalStock = 0.0;

            foreach (Item item in ds.Items.Values) {
                totalStock += item.Stock * item.Value;
            }

            Assert.AreEqual(expectedTotalStockValue, totalStock);
        }

        [TestCase]
        public void HasCorrectOrderCostCheckSum()
        {
            DataSource ds = new DataSourceMock();
            var expectedOrderCostCheckSum = 1700.0;

            var orderCostCheckSum = 0.0;

            foreach (Item item in ds.Items.Values)
            {
                if (item is ProcuredItem)
                {
                    orderCostCheckSum += (item as ProcuredItem).OrderCosts;
                }
            }

            Assert.AreEqual(expectedOrderCostCheckSum, orderCostCheckSum);
        }

        [TestCase]
        public void HasCorrectProcurementLeadTimeCheckSum()
        {
            DataSource ds = new DataSourceMock();
            var expectedProcurementLeadTimeCheckSum = 44.11;

            var procurementLeadTimeCheckSum = 0.0;

            foreach (Item item in ds.Items.Values)
            {
                if (item is ProcuredItem)
                {
                    procurementLeadTimeCheckSum += (item as ProcuredItem).ProcureLeadTime;
                }
            }

            Assert.AreEqual(expectedProcurementLeadTimeCheckSum, procurementLeadTimeCheckSum);
        }

        [TestCase]
        public void HasCorrectProcurementLeadTimeDeviationCheckSum()
        {
            DataSource ds = new DataSourceMock();
            var expectedProcurementLeadTimeDeviationCheckSum = 8.8;

            var procurementLeadTimeDeviationCheckSum = 0.0;

            foreach (Item item in ds.Items.Values)
            {
                if (item is ProcuredItem)
                {
                    procurementLeadTimeDeviationCheckSum += (item as ProcuredItem).ProcureLeadTimeDeviation;
                }
            }

            Assert.AreEqual(expectedProcurementLeadTimeDeviationCheckSum, procurementLeadTimeDeviationCheckSum);
        }

        [TestCase]
        public void UsedInWorksCorrectly()
        {
            DataSource ds = new DataSourceMock();

            foreach (Item item in ds.Items.Values) {
                if (item is FinishedProduct) {
                    Assert.AreEqual(0, item.UsedInProducts.Count);
                }
                if (item is UnfinishedProduct)
                {
                    Assert.AreNotEqual(0, item.UsedInProducts.Count);
                }
                if (item is ProcuredItem)
                {
                    Assert.AreNotEqual(0, item.UsedInProducts.Count);
                }
            }
        }

        [TestCase]
        public void WhereUsedListWorksWithItem32()
        {
            DataSource ds = new DataSourceMock();
            var item = ds.Items[32];

            var whereUsedList = BillOfMaterialUtil.CreateWhereUsedList(item);

            Assert.IsTrue(whereUsedList.Contains(ds.Items[1] as Product));
            Assert.IsTrue(whereUsedList.Contains(ds.Items[2] as Product));
            Assert.IsTrue(whereUsedList.Contains(ds.Items[3] as Product));

            Assert.AreEqual(3, BillOfMaterialUtil.CreateBillOfMaterial(ds.Items[1] as Product)[item]);
            Assert.AreEqual(3, BillOfMaterialUtil.CreateBillOfMaterial(ds.Items[2] as Product)[item]);
            Assert.AreEqual(3, BillOfMaterialUtil.CreateBillOfMaterial(ds.Items[3] as Product)[item]);
        }

        [TestCase]
        public void CreateBillOfMaterialTest()
        {
            var dataSource = new DataSourceMock();
            var procuredItem = (ProcuredItem)dataSource.Items[24];
            var p1 = dataSource.Items[1] as FinishedProduct;
            var p2 = dataSource.Items[2] as FinishedProduct;
            var p3 = dataSource.Items[3] as FinishedProduct;

            var bom1 = BillOfMaterialUtil.CreateBillOfMaterial(p1);
            var bom2 = BillOfMaterialUtil.CreateBillOfMaterial(p2);
            var bom3 = BillOfMaterialUtil.CreateBillOfMaterial(p3);

            Assert.AreEqual(7, bom1[procuredItem]);
            Assert.AreEqual(7, bom2[procuredItem]);
            Assert.AreEqual(7, bom3[procuredItem]);
        }

        [TestCase]
        public void CreateWhereUsedListTest()
        {
            var dataSource = new DataSourceMock();
            var procuredItem = (ProcuredItem)dataSource.Items[24];
            
            var p1 = dataSource.Items[1] as FinishedProduct;
            var p2 = dataSource.Items[2] as FinishedProduct;
            var p3 = dataSource.Items[3] as FinishedProduct;
            Console.WriteLine();
            Assert.AreEqual(1, (from q in procuredItem.UsageQuantities where q.Key.Id == 1 select q).Count());
            Assert.AreEqual(1, procuredItem.UsageQuantities[p1]);
            Assert.AreEqual(1, procuredItem.UsageQuantities[p2]);
            Assert.AreEqual(1, procuredItem.UsageQuantities[p3]);

            var whereUsedList = BillOfMaterialUtil.CreateWhereUsedList(procuredItem);

            Assert.AreEqual(13, whereUsedList.Count);
            Assert.AreEqual(7, (from product in whereUsedList where product == p1 select BillOfMaterialUtil.CreateBillOfMaterial(product)[procuredItem]).First());
            Assert.AreEqual(7, (from product in whereUsedList where product == p2 select BillOfMaterialUtil.CreateBillOfMaterial(product)[procuredItem]).First());
            Assert.AreEqual(7, (from product in whereUsedList where product == p3 select BillOfMaterialUtil.CreateBillOfMaterial(product)[procuredItem]).First());

        }

        [TestCase]
        public void HasCorrectNumberOfWorkplaces() {

            DataSource ds = new DataSourceMock();

            Assert.AreEqual(14, ds.Workplaces.Values.Count);
        }
    }
}
