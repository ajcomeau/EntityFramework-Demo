using Microsoft.EntityFrameworkCore;
using NorthwindUI.Data;
using NorthwindUI.Models;
using System.Diagnostics.Eventing.Reader;

namespace NorthwindUI
{
    public partial class Basic : Form
    {
        // This is a demo project for using EF Core. See more details at:
        // https://youtu.be/1a0pz5aTL5o  

        // Define instances of context and binding source at form level.
        NorthwindContext nwContext = new NorthwindContext();
        BindingSource nwBinding = new BindingSource();

        public Basic()
        {
            InitializeComponent();
        }

        private void Basic_Load(object sender, EventArgs e)
        {
            // Load necessary tables from context.
            nwContext.Products.Load();
            nwContext.Categories.Load();
            nwContext.Suppliers.Load();

            // Set binding data source to product table.
            nwBinding.DataSource = nwContext.Products.Local.ToBindingList();

            // Set grid data source to binding source.
            dgvDisplay.DataSource = nwBinding;

            // Remove columns that don't need to be displayed.
            dgvDisplay.Columns.Remove(nameof(Product.OrderDetails));
            dgvDisplay.Columns.Remove(nameof(Product.Supplier));
            dgvDisplay.Columns.Remove(nameof(Product.Category));
            dgvDisplay.Columns.Remove(nameof(Product.SupplierId));
            dgvDisplay.Columns.Remove(nameof(Product.CategoryId));

            // These columns are set to custom properties in the partial product class.
            // See the Supplemental.cs model class.
            dgvDisplay.Columns[nameof(Product.SupplierCompany)].Name = "Suplier Name";
            dgvDisplay.Columns[nameof(Product.CategoryName)].Name = "Category";

            // Set the combo box data source to the binding source.
            cboSelect.DataSource = nwBinding;
            cboSelect.DisplayMember = nameof(Product.ProductName);
            cboSelect.ValueMember = nameof(Product.ProductId);
            
            // Bind the text box to the category name from the binding source.
            txtInfo.DataBindings.Add("text", nwBinding, "CategoryName");
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save changes and notify user.
            nwContext.SaveChanges();
            MessageBox.Show("All changes saved.", "Save complete...");
        }
    }
}
