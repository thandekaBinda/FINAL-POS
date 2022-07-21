using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSBunifu.Config;
using System.Data.SqlClient;




namespace POSBunifu
{
    public partial class Ingredients : Form
    {
        public Ingredients()
        {
            InitializeComponent();
        }
        SQLConfig user = new SQLConfig();
        UsableFunction useFunc = new UsableFunction();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.comboBox1.FormattingEnabled = true;
            //this.comboBox1.Items.AddRange(new object[] {
            //"Vegetables",
            //"Spices and Herbs",
            //"Oils"});
        }

        private void Ingredients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lafusionPOSDataSet1.INGREDIENTS' table. You can move, or remove it, as needed.
            this.iNGREDIENTSTableAdapter1.Fill(this.lafusionPOSDataSet1.INGREDIENTS);
            // TODO: This line of code loads data into the 'lafusionPOSDataSet.INGREDIENTS' table. You can move, or remove it, as needed.
            //this.iNGREDIENTSTableAdapter.Fill(this.lafusionPOSDataSet.INGREDIENTS);
            //this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.comboBox1.FormattingEnabled = true;
            //this.comboBox1.Items.AddRange(new object[] {
            //txtIngredient.Text

            //});
        }
        class Connect
        {
            public SqlConnection conn = new SqlConnection();
            public SqlCommand cmd = new SqlCommand();
            public string connection_string = @"Data Source=laptop-tla564ds;Initial Catalog=lafusionPOS;Integrated Security=True";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Connect obj = new Connect();
            obj.conn.ConnectionString = obj.connection_string;
            obj.conn.Open();
            string insertIngredient = "insert into ingredients(ingredient_name)values('" + txtIngredient.Text + "')";
            obj.cmd.Connection = obj.conn;
            obj.cmd.CommandText = insertIngredient;
            obj.cmd.ExecuteNonQuery();
            obj.conn.Close();
            MessageBox.Show("Ingredient has been added");


            //user.sqlselect = "SELECT * FROM INGREDIENTS ";

            //user.sqladd = "INSERT INTO INGREDIENTS (INGREDIENT_NAME) VALUES " +
            //   " (" + txtIngredient.Text + ",'";

            //user.msgadd = "New INGREDIENT has been saved in the database.";



            //user.SaveUpdate(user.sqlselect, user.sqladd, user.msgadd, user.sqledit, user.msgedit);


            ////btnNew_Click(sender, e);


            //this.iNGREDIENTSTableAdapter.Fill(this.lafusionPOSDataSet.INGREDIENTS);
            //this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.comboBox1.FormattingEnabled = true;
            //this.comboBox1.Items.AddRange(new object[] {
            //txtIngredient.Text

            ///*}*/);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //user.sqladd = "INSERT INTO INGREDIENTS (INGREDIENT_NAME) VALUES " +
            // " (" + comboBox1.SelectedItem + "')";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            user.sql = "DELETE FROM Ingredients WHERE Ingredient_id = " + dataGridView1.CurrentRow.Cells[0].Value;

            user.SaveDataMsg(user.sql, "User has been deleted in the database.");

            //btnNew_Click(sender, e);
        }
    }

    internal class Connect
    {
    }
}
