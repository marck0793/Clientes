using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Poryecto_InfoAplicada
{
    public partial class Form1 : Form
    {
        TextBox tbCedula = new TextBox();
        Label lCedula = new Label();
        SqlConnection con = Poryecto_InfoAplicada.Modelo.BDComun.ObtenerConexion();
        ComboBox cbCategorias;
        Panel patito;
        ComboBox cbSubcategorias;

        public Form1()
        {
            InitializeComponent();
            lCedula.Text = "Cedula";
            lCedula.SetBounds(0, 0, 70, 20);
            tbCedula.SetBounds(0, 20, 90, 20);
            tbCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCedula_KeyPress);
        }

        private void tbCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SqlDataAdapter adapter = new SqlDataAdapter("select i.CustomerID, i.FirstName, i.LastName from Individual i inner join SalesOrderHeader soh on i.CustomerID like '%" + tbCedula.Text + "%' and soh.CustomerID = i.CustomerID group by i.CustomerID, i.FirstName, i.LastName order by i.CustomerID", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tpClientes.Controls.Remove(dgvClientes);
                dgvClientes = new DataGridView();
                dgvClientes.Width = 500;
                dgvClientes.Height = 600;
                dgvClientes.DataSource = dt;
                tpClientes.Controls.Add(dgvClientes);
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorks2000DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.adventureWorks2000DataSet.Customer);

        }

        private void actualizarLista(String consulta) {

            SqlDataAdapter adapt = new SqlDataAdapter(consulta, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            tpClientes.Controls.Remove(dgvClientes);
            dgvClientes = new DataGridView();
            dgvClientes.Width = 500;
            dgvClientes.Height = 600;
            dgvClientes.DataSource = dt;
            tpClientes.Controls.Add(dgvClientes);
        }

        private void cbFiltro_SelectedValueChanged(object sender, EventArgs e)
        {
            pDinamico.Controls.Clear();
            
            DataTable dt;
            switch (cbFiltro.Text)
            {
                case "Cedula":
                    
                    pDinamico.Controls.Add(lCedula);
                    pDinamico.Controls.Add(tbCedula);

                    
                    break;
                case "Region":
                    
                    break;
                case "VIP":

                    actualizarLista("select i.CustomerID, i.FirstName, i.LastName, SUM(soh.totaldue) as totalCompras from Individual i inner join SalesOrderHeader soh on i.CustomerID=soh.CustomerID group by i.CustomerID, i.FirstName, i.LastName HAVING SUM(soh.totaldue) > (select avg(totaldue) from SalesOrderHeader) order by totalCompras desc;");
                    break;
                case "Categorias":
                    //sql
                    
                     SqlDataAdapter dad = new SqlDataAdapter("SELECT name FROM ProductCategory",con);
                    dt = new DataTable();
                    dad.Fill(dt);
                    DataRow fila = dt.NewRow();
                    fila["Name"]="";
                    dt.Rows.Add(fila);
                    
                    //crear combobox
                    //--Categorias
                     cbCategorias = new ComboBox();
                    cbCategorias.DataSource = dt;
                    
                     cbCategorias.DisplayMember = "Name";
                    cbCategorias.ValueMember = "ProductCategoryId";
                    cbCategorias.SelectedValue = "";
                    cbCategorias.SelectedValueChanged += new System.EventHandler(this.cbCategorias_selectedValueChanged);
                    cbCategorias.SetBounds(0,0,100,20);
                   
                    pDinamico.Controls.Add(cbCategorias);
                    patito = new Panel();
                    patito.SetBounds(120,0,130,50);
                    pDinamico.Controls.Add(patito);

                    
                    actualizarLista("select i.CustomerID, i.FirstName, i.LastName from Individual i inner join SalesOrderHeader soh on soh.CustomerID = i.CustomerID inner join SalesOrderDetail sod on sod.SalesOrderID = soh.SalesOrderID inner join Product p on p.ProductID = sod.ProductID  inner join ProductSubCategory ps on ps.ProductSubCategoryID = p.ProductSubCategoryID inner join ProductCategory pc on pc.ProductCategoryID = ps.ProductCategoryID and pc.ProductCategoryID = (select ProductCategoryID from ProductCategory where Name = '" + cbCategorias.Text + "') group by i.CustomerID, i.FirstName, i.LastName;");
                    break;
                default:

                    actualizarLista( "select i.CustomerID, i.FirstName, i.LastName from Individual i inner join SalesOrderHeader soh on soh.CustomerID = i.CustomerID group by i.CustomerID, i.FirstName, i.LastName");
                    break;
            }
        }

        private void cbCategorias_selectedValueChanged(object sender, EventArgs e) {

            
            //--SubCategorias
            cbSubcategorias = new ComboBox();
            
            SqlDataAdapter dad = new SqlDataAdapter("select psc.Name as Name from ProductSubCategory psc inner join ProductCategory pc on pc.ProductCategoryID = psc.ProductCategoryID and psc.ProductCategoryID= (select ProductCategoryID from ProductCategory where Name = '" + this.cbCategorias.Text + "') order by ProductSubCategoryID; ", con);
            DataTable dt = new DataTable();
            dad.Fill(dt);
            cbSubcategorias.DataSource = dt;
            cbSubcategorias.DisplayMember = "Name";
            cbSubcategorias.ValueMember = "Name";
            cbSubcategorias.SelectedValueChanged += new System.EventHandler(this.cbSubcategorias_selectedValueChanged);
            patito.Controls.Clear();
            patito.Controls.Add(cbSubcategorias);

            actualizarLista("select i.CustomerID, i.FirstName, i.LastName from Individual i inner join SalesOrderHeader soh on soh.CustomerID = i.CustomerID inner join SalesOrderDetail sod on sod.SalesOrderID = soh.SalesOrderID inner join Product p on p.ProductID = sod.ProductID inner join ProductSubCategory ps on ps.ProductSubCategoryID = (select ProductSubCategoryID from ProductSubCategory where name = '"+cbSubcategorias.Text+"') group by i.CustomerID, i.FirstName, i.LastName;");
           
            
        }

        private void cbSubcategorias_selectedValueChanged(object sender, EventArgs e) {
            actualizarLista("select i.CustomerID, i.FirstName, i.LastName from Individual i inner join SalesOrderHeader soh on soh.CustomerID = i.CustomerID inner join SalesOrderDetail sod on sod.SalesOrderID = soh.SalesOrderID inner join Product p on p.ProductID = sod.ProductID inner join ProductSubCategory ps on ps.ProductSubCategoryID = (select ProductSubCategoryID from ProductSubCategory where name = '" + cbSubcategorias.Text + "') group by i.CustomerID, i.FirstName, i.LastName;");
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
