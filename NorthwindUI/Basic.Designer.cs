
namespace NorthwindUI
{
    partial class Basic
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboSelect = new ComboBox();
            dgvDisplay = new DataGridView();
            btnSave = new Button();
            txtInfo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).BeginInit();
            SuspendLayout();
            // 
            // cboSelect
            // 
            cboSelect.FormattingEnabled = true;
            cboSelect.Location = new Point(12, 12);
            cboSelect.Name = "cboSelect";
            cboSelect.Size = new Size(430, 23);
            cboSelect.TabIndex = 0;
            // 
            // dgvDisplay
            // 
            dgvDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDisplay.Location = new Point(12, 40);
            dgvDisplay.Name = "dgvDisplay";
            dgvDisplay.Size = new Size(735, 420);
            dgvDisplay.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(651, 469);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(540, 12);
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(169, 23);
            txtInfo.TabIndex = 3;
            // 
            // Basic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 504);
            Controls.Add(txtInfo);
            Controls.Add(btnSave);
            Controls.Add(dgvDisplay);
            Controls.Add(cboSelect);
            Name = "Basic";
            Text = "Basic Grid and Controls";
            Load += Basic_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSelect;
        private DataGridView dgvDisplay;
        private Button btnSave;
        private TextBox txtInfo;
    }
}
