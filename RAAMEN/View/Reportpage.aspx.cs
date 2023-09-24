using RAAMEN.Controller;
using RAAMEN.Dataset;
using RAAMEN.Model;
using RAAMEN.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View
{
    public partial class Reportpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RamenReport report = new RamenReport();
            CrystalReportViewer1.ReportSource = report;
            RaamenDataset dataset = getData(HeaderController.getAllHeader());
            report.SetDataSource(dataset);
        }

        protected RaamenDataset getData(List<Header> header)
        {
            RaamenDataset dataset = new RaamenDataset();
            var headerTable = dataset.Header;
            var detailTable = dataset.Detail;

            foreach (Header data in header)
            {
                var headerRow = headerTable.NewRow();
                headerRow["Id"] = data.Id;
                headerRow["CustomerId"] = data.CustomerId;
                headerRow["StaffId"] = data.StaffId;
                headerRow["Date"] = data.Date;
                headerRow["TotalPrice"] = HeaderController.totalPriceHeader(data);
                headerTable.Rows.Add(headerRow);

                List<Detail> detail = DetailController.getDetail(data.Id);
                foreach (Detail data1 in detail)
                {
                    var detailRow = detailTable.NewRow();
                    detailRow["HeaderId"] = data1.HeaderId;
                    detailRow["RamenId"] = data1.RamenId;
                    detailRow["Quantity"] = data1.Quantity;
                    detailTable.Rows.Add(detailRow);
                }
            }

            return dataset;
        }
    }
}