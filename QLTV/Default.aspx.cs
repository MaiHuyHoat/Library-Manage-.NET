using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using QLTV.Data.Model;
using QLTV.Data.Entity;
namespace QLTV
{
    public partial class _Default : Page
    {
        DBContext dbContext;

        public _Default()
        {


        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.dbContext = new DBContext();
            loadData(null);
        }
        private void loadData(Dictionary<string, string> constraint)
        {
            var query = from author in dbContext.Author
                        where author.Deleted == 0
                        select new { author };


            if (constraint != null)
            {
                if (constraint.TryGetValue("name", out string name))
                    query = query.Where(data => data.author.Name.ToLower().Contains(name.ToLower()));
            }


            List<TacGiaShow> listData = query.Select(data => new TacGiaShow
            {
                Id = data.author.Id,
                Name = data.author.Name
            }).ToList();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Rows.Clear();
            foreach (TacGiaShow tgs in listData)
            {
                dataTable.Rows.Add(tgs.Id.ToString(), tgs.Name);
            }
            GridViewTacGia.DataSource = dataTable;
            GridViewTacGia.DataBind();
        }
    }
}