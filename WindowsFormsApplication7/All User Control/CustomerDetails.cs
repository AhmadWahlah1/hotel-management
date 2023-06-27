using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7.All_User_Control
{
    public partial class CustomerDetails : UserControl
    {
        Function fn = new Function();
        String query;

        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void txtsearchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtsearchby.SelectedIndex == 0)
            {
                query = "SELECT customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.addres, customer.checkin, customer.checkout, rooms.roomNo, rooms.roomtype, rooms.bed, rooms.price, CASE WHEN customer.checkout IS NOT NULL THEN CASE WHEN checkby.checkoutby IS NULL THEN '0' ELSE checkby.checkoutby END ELSE '' END AS CheckoutBy FROM customer INNER JOIN rooms ON customer.roomid = rooms.roomid LEFT JOIN checkby ON checkby.ceid = customer.ceid";
                getRecord(query);
            }
            else if (txtsearchby.SelectedIndex == 1)
            {
                query = "SELECT customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.addres, customer.checkin, customer.checkout, rooms.roomNo, rooms.roomtype, rooms.bed, rooms.price, CASE WHEN customer.checkout IS NOT NULL THEN CASE WHEN employee.cname IS NULL THEN '0' ELSE employee.cname END ELSE '' END AS CheckoutBy FROM customer INNER JOIN rooms ON customer.roomid = rooms.roomid LEFT JOIN employee ON customer.empid = employee.eid WHERE checkout IS NULL";
                getRecord(query);
            }
            else if (txtsearchby.SelectedIndex == 2)
            {
                query = "SELECT customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.addres, customer.checkin, customer.checkout, rooms.roomNo, rooms.roomtype, rooms.bed, rooms.price, CASE WHEN employee.cname IS NULL THEN '0' ELSE employee.cname END AS CheckoutBy FROM customer INNER JOIN rooms ON customer.roomid = rooms.roomid LEFT JOIN employee ON customer.empid = employee.eid WHERE checkout IS NOT NULL";
                getRecord(query);
            }
        }


        private void getRecord(String query)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView5.DataSource = ds.Tables[0];
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            txtsearchby.Focus();
        }

        private void guna2DataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}