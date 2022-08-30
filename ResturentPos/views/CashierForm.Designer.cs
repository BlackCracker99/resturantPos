namespace ResturentPos.views
{
    partial class CashierForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanelDrawerMenu = new MetroFramework.Controls.MetroPanel();
            this.metroTileBillMenuBtn = new MetroFramework.Controls.MetroTile();
            this.metroTileFoodsMenuBtn = new MetroFramework.Controls.MetroTile();
            this.metroTileCatergoryMenuBtn = new MetroFramework.Controls.MetroTile();
            this.gbCatergoryMenu = new System.Windows.Forms.GroupBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnDeleteSubCatergory = new MetroFramework.Controls.MetroButton();
            this.btnUpdateSubCatergory = new MetroFramework.Controls.MetroButton();
            this.btnAddSubCatergory = new MetroFramework.Controls.MetroButton();
            this.btnDeleteCatergory = new MetroFramework.Controls.MetroButton();
            this.tbSubCatergories = new MetroFramework.Controls.MetroTextBox();
            this.cbCatergories = new MetroFramework.Controls.MetroComboBox();
            this.btnUpdateCatergory = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAddCatergory = new MetroFramework.Controls.MetroButton();
            this.tbCatergory = new MetroFramework.Controls.MetroTextBox();
            this.tblCatergories = new System.Windows.Forms.DataGridView();
            this.gbBillMenu = new System.Windows.Forms.GroupBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanelDrawerMenu.SuspendLayout();
            this.gbCatergoryMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCatergories)).BeginInit();
            this.gbBillMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelDrawerMenu
            // 
            this.metroPanelDrawerMenu.Controls.Add(this.metroTileBillMenuBtn);
            this.metroPanelDrawerMenu.Controls.Add(this.metroTileFoodsMenuBtn);
            this.metroPanelDrawerMenu.Controls.Add(this.metroTileCatergoryMenuBtn);
            this.metroPanelDrawerMenu.HorizontalScrollbarBarColor = true;
            this.metroPanelDrawerMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelDrawerMenu.HorizontalScrollbarSize = 10;
            this.metroPanelDrawerMenu.Location = new System.Drawing.Point(-1, 5);
            this.metroPanelDrawerMenu.Name = "metroPanelDrawerMenu";
            this.metroPanelDrawerMenu.Size = new System.Drawing.Size(94, 539);
            this.metroPanelDrawerMenu.TabIndex = 0;
            this.metroPanelDrawerMenu.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelDrawerMenu.VerticalScrollbarBarColor = true;
            this.metroPanelDrawerMenu.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelDrawerMenu.VerticalScrollbarSize = 10;
            // 
            // metroTileBillMenuBtn
            // 
            this.metroTileBillMenuBtn.ActiveControl = null;
            this.metroTileBillMenuBtn.Location = new System.Drawing.Point(3, 3);
            this.metroTileBillMenuBtn.Name = "metroTileBillMenuBtn";
            this.metroTileBillMenuBtn.Size = new System.Drawing.Size(88, 112);
            this.metroTileBillMenuBtn.TabIndex = 4;
            this.metroTileBillMenuBtn.Text = "Bill";
            this.metroTileBillMenuBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileBillMenuBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTileBillMenuBtn.TileImage = global::ResturentPos.Properties.Resources.sm_bill;
            this.metroTileBillMenuBtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileBillMenuBtn.UseSelectable = true;
            this.metroTileBillMenuBtn.UseTileImage = true;
            this.metroTileBillMenuBtn.Click += new System.EventHandler(this.metroTileBillMenuBtn_Click);
            // 
            // metroTileFoodsMenuBtn
            // 
            this.metroTileFoodsMenuBtn.ActiveControl = null;
            this.metroTileFoodsMenuBtn.Location = new System.Drawing.Point(3, 239);
            this.metroTileFoodsMenuBtn.Name = "metroTileFoodsMenuBtn";
            this.metroTileFoodsMenuBtn.Size = new System.Drawing.Size(88, 112);
            this.metroTileFoodsMenuBtn.TabIndex = 3;
            this.metroTileFoodsMenuBtn.Text = "Foods";
            this.metroTileFoodsMenuBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileFoodsMenuBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTileFoodsMenuBtn.TileImage = global::ResturentPos.Properties.Resources.sm_food;
            this.metroTileFoodsMenuBtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileFoodsMenuBtn.UseSelectable = true;
            this.metroTileFoodsMenuBtn.UseTileImage = true;
            // 
            // metroTileCatergoryMenuBtn
            // 
            this.metroTileCatergoryMenuBtn.ActiveControl = null;
            this.metroTileCatergoryMenuBtn.Location = new System.Drawing.Point(3, 121);
            this.metroTileCatergoryMenuBtn.Name = "metroTileCatergoryMenuBtn";
            this.metroTileCatergoryMenuBtn.Size = new System.Drawing.Size(88, 112);
            this.metroTileCatergoryMenuBtn.TabIndex = 2;
            this.metroTileCatergoryMenuBtn.Text = "Catergory";
            this.metroTileCatergoryMenuBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileCatergoryMenuBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTileCatergoryMenuBtn.TileImage = global::ResturentPos.Properties.Resources.icons8_category_58;
            this.metroTileCatergoryMenuBtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileCatergoryMenuBtn.UseSelectable = true;
            this.metroTileCatergoryMenuBtn.UseTileImage = true;
            this.metroTileCatergoryMenuBtn.Click += new System.EventHandler(this.metroTileCatergoryMenuBtn_Click);
            // 
            // gbCatergoryMenu
            // 
            this.gbCatergoryMenu.Controls.Add(this.btnSearch);
            this.gbCatergoryMenu.Controls.Add(this.metroLabel2);
            this.gbCatergoryMenu.Controls.Add(this.btnDeleteSubCatergory);
            this.gbCatergoryMenu.Controls.Add(this.btnUpdateSubCatergory);
            this.gbCatergoryMenu.Controls.Add(this.btnAddSubCatergory);
            this.gbCatergoryMenu.Controls.Add(this.btnDeleteCatergory);
            this.gbCatergoryMenu.Controls.Add(this.tbSubCatergories);
            this.gbCatergoryMenu.Controls.Add(this.cbCatergories);
            this.gbCatergoryMenu.Controls.Add(this.btnUpdateCatergory);
            this.gbCatergoryMenu.Controls.Add(this.metroLabel1);
            this.gbCatergoryMenu.Controls.Add(this.btnAddCatergory);
            this.gbCatergoryMenu.Controls.Add(this.tbCatergory);
            this.gbCatergoryMenu.Controls.Add(this.tblCatergories);
            this.gbCatergoryMenu.Location = new System.Drawing.Point(99, 32);
            this.gbCatergoryMenu.Name = "gbCatergoryMenu";
            this.gbCatergoryMenu.Size = new System.Drawing.Size(785, 500);
            this.gbCatergoryMenu.TabIndex = 2;
            this.gbCatergoryMenu.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.Location = new System.Drawing.Point(693, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 29);
            this.btnSearch.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "Search";
            this.btnSearch.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(531, -4);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(103, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Sub Catergories";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = true;
            // 
            // btnDeleteSubCatergory
            // 
            this.btnDeleteSubCatergory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteSubCatergory.Location = new System.Drawing.Point(663, 108);
            this.btnDeleteSubCatergory.Name = "btnDeleteSubCatergory";
            this.btnDeleteSubCatergory.Size = new System.Drawing.Size(93, 23);
            this.btnDeleteSubCatergory.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDeleteSubCatergory.TabIndex = 29;
            this.btnDeleteSubCatergory.Text = "Delete";
            this.btnDeleteSubCatergory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDeleteSubCatergory.UseSelectable = true;
            this.btnDeleteSubCatergory.UseStyleColors = true;
            // 
            // btnUpdateSubCatergory
            // 
            this.btnUpdateSubCatergory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateSubCatergory.Location = new System.Drawing.Point(543, 108);
            this.btnUpdateSubCatergory.Name = "btnUpdateSubCatergory";
            this.btnUpdateSubCatergory.Size = new System.Drawing.Size(114, 23);
            this.btnUpdateSubCatergory.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnUpdateSubCatergory.TabIndex = 28;
            this.btnUpdateSubCatergory.Text = "Update";
            this.btnUpdateSubCatergory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnUpdateSubCatergory.UseSelectable = true;
            this.btnUpdateSubCatergory.UseStyleColors = true;
            // 
            // btnAddSubCatergory
            // 
            this.btnAddSubCatergory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddSubCatergory.Location = new System.Drawing.Point(430, 108);
            this.btnAddSubCatergory.Name = "btnAddSubCatergory";
            this.btnAddSubCatergory.Size = new System.Drawing.Size(107, 23);
            this.btnAddSubCatergory.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAddSubCatergory.TabIndex = 27;
            this.btnAddSubCatergory.Text = "Add";
            this.btnAddSubCatergory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddSubCatergory.UseSelectable = true;
            this.btnAddSubCatergory.UseStyleColors = true;
            // 
            // btnDeleteCatergory
            // 
            this.btnDeleteCatergory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteCatergory.Location = new System.Drawing.Point(218, 70);
            this.btnDeleteCatergory.Name = "btnDeleteCatergory";
            this.btnDeleteCatergory.Size = new System.Drawing.Size(93, 23);
            this.btnDeleteCatergory.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDeleteCatergory.TabIndex = 26;
            this.btnDeleteCatergory.Text = "Delete";
            this.btnDeleteCatergory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDeleteCatergory.UseSelectable = true;
            this.btnDeleteCatergory.UseStyleColors = true;
            // 
            // tbSubCatergories
            // 
            // 
            // 
            // 
            this.tbSubCatergories.CustomButton.Image = null;
            this.tbSubCatergories.CustomButton.Location = new System.Drawing.Point(304, 1);
            this.tbSubCatergories.CustomButton.Name = "";
            this.tbSubCatergories.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSubCatergories.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSubCatergories.CustomButton.TabIndex = 1;
            this.tbSubCatergories.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSubCatergories.CustomButton.UseSelectable = true;
            this.tbSubCatergories.CustomButton.Visible = false;
            this.tbSubCatergories.Lines = new string[0];
            this.tbSubCatergories.Location = new System.Drawing.Point(430, 74);
            this.tbSubCatergories.MaxLength = 32767;
            this.tbSubCatergories.Name = "tbSubCatergories";
            this.tbSubCatergories.PasswordChar = '\0';
            this.tbSubCatergories.PromptText = "Sub Catergory";
            this.tbSubCatergories.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSubCatergories.SelectedText = "";
            this.tbSubCatergories.SelectionLength = 0;
            this.tbSubCatergories.SelectionStart = 0;
            this.tbSubCatergories.ShortcutsEnabled = true;
            this.tbSubCatergories.Size = new System.Drawing.Size(326, 23);
            this.tbSubCatergories.TabIndex = 25;
            this.tbSubCatergories.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSubCatergories.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbSubCatergories.UseSelectable = true;
            this.tbSubCatergories.WaterMark = "Sub Catergory";
            this.tbSubCatergories.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSubCatergories.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbCatergories
            // 
            this.cbCatergories.FormattingEnabled = true;
            this.cbCatergories.ItemHeight = 23;
            this.cbCatergories.Location = new System.Drawing.Point(430, 35);
            this.cbCatergories.Name = "cbCatergories";
            this.cbCatergories.Size = new System.Drawing.Size(260, 29);
            this.cbCatergories.TabIndex = 24;
            this.cbCatergories.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbCatergories.UseSelectable = true;
            // 
            // btnUpdateCatergory
            // 
            this.btnUpdateCatergory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateCatergory.Location = new System.Drawing.Point(116, 70);
            this.btnUpdateCatergory.Name = "btnUpdateCatergory";
            this.btnUpdateCatergory.Size = new System.Drawing.Size(96, 23);
            this.btnUpdateCatergory.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnUpdateCatergory.TabIndex = 23;
            this.btnUpdateCatergory.Text = "Update";
            this.btnUpdateCatergory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnUpdateCatergory.UseSelectable = true;
            this.btnUpdateCatergory.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(116, -3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel1.TabIndex = 22;
            this.metroLabel1.Text = "Catergories";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // btnAddCatergory
            // 
            this.btnAddCatergory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddCatergory.Location = new System.Drawing.Point(15, 70);
            this.btnAddCatergory.Name = "btnAddCatergory";
            this.btnAddCatergory.Size = new System.Drawing.Size(95, 23);
            this.btnAddCatergory.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAddCatergory.TabIndex = 21;
            this.btnAddCatergory.Text = "Add";
            this.btnAddCatergory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddCatergory.UseSelectable = true;
            this.btnAddCatergory.UseStyleColors = true;
            // 
            // tbCatergory
            // 
            // 
            // 
            // 
            this.tbCatergory.CustomButton.Image = null;
            this.tbCatergory.CustomButton.Location = new System.Drawing.Point(274, 1);
            this.tbCatergory.CustomButton.Name = "";
            this.tbCatergory.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbCatergory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCatergory.CustomButton.TabIndex = 1;
            this.tbCatergory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCatergory.CustomButton.UseSelectable = true;
            this.tbCatergory.CustomButton.Visible = false;
            this.tbCatergory.Lines = new string[0];
            this.tbCatergory.Location = new System.Drawing.Point(15, 35);
            this.tbCatergory.MaxLength = 32767;
            this.tbCatergory.Name = "tbCatergory";
            this.tbCatergory.PasswordChar = '\0';
            this.tbCatergory.PromptText = "Catergory";
            this.tbCatergory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCatergory.SelectedText = "";
            this.tbCatergory.SelectionLength = 0;
            this.tbCatergory.SelectionStart = 0;
            this.tbCatergory.ShortcutsEnabled = true;
            this.tbCatergory.Size = new System.Drawing.Size(296, 23);
            this.tbCatergory.TabIndex = 20;
            this.tbCatergory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCatergory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbCatergory.UseSelectable = true;
            this.tbCatergory.WaterMark = "Catergory";
            this.tbCatergory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCatergory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tblCatergories
            // 
            this.tblCatergories.AllowUserToAddRows = false;
            this.tblCatergories.AllowUserToDeleteRows = false;
            this.tblCatergories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblCatergories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblCatergories.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblCatergories.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblCatergories.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tblCatergories.Location = new System.Drawing.Point(3, 137);
            this.tblCatergories.Name = "tblCatergories";
            this.tblCatergories.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.tblCatergories.Size = new System.Drawing.Size(779, 360);
            this.tblCatergories.TabIndex = 19;
            // 
            // gbBillMenu
            // 
            this.gbBillMenu.Controls.Add(this.metroLabel4);
            this.gbBillMenu.Location = new System.Drawing.Point(100, 33);
            this.gbBillMenu.Name = "gbBillMenu";
            this.gbBillMenu.Size = new System.Drawing.Size(785, 500);
            this.gbBillMenu.TabIndex = 3;
            this.gbBillMenu.TabStop = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(360, -3);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel4.TabIndex = 22;
            this.metroLabel4.Text = "Bill Menu";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseStyleColors = true;
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 543);
            this.Controls.Add(this.gbBillMenu);
            this.Controls.Add(this.gbCatergoryMenu);
            this.Controls.Add(this.metroPanelDrawerMenu);
            this.Name = "CashierForm";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.CashierForm_Load);
            this.metroPanelDrawerMenu.ResumeLayout(false);
            this.gbCatergoryMenu.ResumeLayout(false);
            this.gbCatergoryMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCatergories)).EndInit();
            this.gbBillMenu.ResumeLayout(false);
            this.gbBillMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelDrawerMenu;
        private MetroFramework.Controls.MetroTile metroTileCatergoryMenuBtn;
        private MetroFramework.Controls.MetroTile metroTileBillMenuBtn;
        private MetroFramework.Controls.MetroTile metroTileFoodsMenuBtn;
        private System.Windows.Forms.GroupBox gbCatergoryMenu;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnDeleteSubCatergory;
        private MetroFramework.Controls.MetroButton btnUpdateSubCatergory;
        private MetroFramework.Controls.MetroButton btnAddSubCatergory;
        private MetroFramework.Controls.MetroButton btnDeleteCatergory;
        private MetroFramework.Controls.MetroTextBox tbSubCatergories;
        private MetroFramework.Controls.MetroComboBox cbCatergories;
        private MetroFramework.Controls.MetroButton btnUpdateCatergory;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnAddCatergory;
        private MetroFramework.Controls.MetroTextBox tbCatergory;
        private System.Windows.Forms.DataGridView tblCatergories;
        private System.Windows.Forms.GroupBox gbBillMenu;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}