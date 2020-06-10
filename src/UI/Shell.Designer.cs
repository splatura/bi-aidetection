﻿using System.IO;
namespace WindowsFormsApp2
{
    partial class Shell
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shell));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 30D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 30D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 30D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSettingsSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_input_path = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tb_telegram_chatid = new System.Windows.Forms.TextBox();
            this.tb_telegram_token = new System.Windows.Forms.TextBox();
            this.lbl_telegram_chatid = new System.Windows.Forms.Label();
            this.lbl_telegram_token = new System.Windows.Forms.Label();
            this.tbDeepstackUrl = new System.Windows.Forms.TextBox();
            this.lbl_input = new System.Windows.Forms.Label();
            this.lbl_deepstackurl = new System.Windows.Forms.Label();
            this.cb_send_errors = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel25 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_log = new System.Windows.Forms.CheckBox();
            this.btn_open_log = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabCameras = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_camstats = new System.Windows.Forms.Label();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCameraDel = new System.Windows.Forms.Button();
            this.btnCameraSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel24 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_threshold_lower = new System.Windows.Forms.TextBox();
            this.lbl_threshold_upper = new System.Windows.Forms.Label();
            this.tb_threshold_upper = new System.Windows.Forms.TextBox();
            this.lbl_threshold_lower = new System.Windows.Forms.Label();
            this.lbl_threshold = new System.Windows.Forms.Label();
            this.lblRelevantObjects = new System.Windows.Forms.Label();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_enabled = new System.Windows.Forms.CheckBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_prefix = new System.Windows.Forms.Label();
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_cooldown = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_telegram = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tbTriggerUrl = new System.Windows.Forms.TextBox();
            this.lblTriggerUrl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_car = new System.Windows.Forms.CheckBox();
            this.cb_truck = new System.Windows.Forms.CheckBox();
            this.cb_bus = new System.Windows.Forms.CheckBox();
            this.cb_boat = new System.Windows.Forms.CheckBox();
            this.cb_airplane = new System.Windows.Forms.CheckBox();
            this.cb_cat = new System.Windows.Forms.CheckBox();
            this.cb_dog = new System.Windows.Forms.CheckBox();
            this.cb_bird = new System.Windows.Forms.CheckBox();
            this.cb_horse = new System.Windows.Forms.CheckBox();
            this.cb_sheep = new System.Windows.Forms.CheckBox();
            this.cb_cow = new System.Windows.Forms.CheckBox();
            this.cb_bear = new System.Windows.Forms.CheckBox();
            this.cb_motorcycle = new System.Windows.Forms.CheckBox();
            this.cb_bicycle = new System.Windows.Forms.CheckBox();
            this.cb_person = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCameraAdd = new System.Windows.Forms.Button();
            this.list2 = new System.Windows.Forms.ListView();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_filter_animal = new System.Windows.Forms.CheckBox();
            this.cb_filter_vehicle = new System.Windows.Forms.CheckBox();
            this.cb_filter_person = new System.Windows.Forms.CheckBox();
            this.cb_filter_success = new System.Windows.Forms.CheckBox();
            this.cb_filter_nosuccess = new System.Windows.Forms.CheckBox();
            this.comboBox_filter_camera = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.list1 = new System.Windows.Forms.ListView();
            this.cb_showFilters = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_objects = new System.Windows.Forms.Label();
            this.cb_showMask = new System.Windows.Forms.CheckBox();
            this.cb_showObjects = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabStats = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel23 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.timeline = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_confidence = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.tabOverview = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_info = new System.Windows.Forms.Label();
            this.lbl_errors = new System.Windows.Forms.Label();
            this.lbl_version = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSettings.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.tableLayoutPanel25.SuspendLayout();
            this.tabCameras.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel24.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabHistory.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.tableLayoutPanel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabStats.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_confidence)).BeginInit();
            this.tabOverview.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "Running in the background";
            this.notifyIcon.BalloonTipTitle = "AI Tool";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "AI Tool";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tableLayoutPanel4);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(946, 436);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnSettingsSave, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.65022F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.34978F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(946, 436);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // BtnSettingsSave
            // 
            this.BtnSettingsSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnSettingsSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettingsSave.Location = new System.Drawing.Point(405, 376);
            this.BtnSettingsSave.Name = "BtnSettingsSave";
            this.BtnSettingsSave.Size = new System.Drawing.Size(136, 57);
            this.BtnSettingsSave.TabIndex = 2;
            this.BtnSettingsSave.Text = "Save";
            this.BtnSettingsSave.UseVisualStyleBackColor = true;
            this.BtnSettingsSave.Click += new System.EventHandler(this.BtnSettingsSave_Click_1);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel25, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.cb_send_errors, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.lbl_deepstackurl, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lbl_input, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tbDeepstackUrl, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.lbl_telegram_token, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.lbl_telegram_chatid, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.tb_telegram_token, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.tb_telegram_chatid, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel18, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(940, 367);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 2;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel18.Controls.Add(this.tbInput, 0, 0);
            this.tableLayoutPanel18.Controls.Add(this.btn_input_path, 1, 0);
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(145, 4);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 1;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(791, 53);
            this.tableLayoutPanel18.TabIndex = 12;
            // 
            // btn_input_path
            // 
            this.btn_input_path.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_input_path.Location = new System.Drawing.Point(721, 15);
            this.btn_input_path.Name = "btn_input_path";
            this.btn_input_path.Size = new System.Drawing.Size(59, 23);
            this.btn_input_path.TabIndex = 2;
            this.btn_input_path.Text = "Select...";
            this.btn_input_path.UseVisualStyleBackColor = true;
            this.btn_input_path.Click += new System.EventHandler(this.btn_input_path_Click);
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.Location = new System.Drawing.Point(3, 14);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(705, 25);
            this.tbInput.TabIndex = 1;
            // 
            // tb_telegram_chatid
            // 
            this.tb_telegram_chatid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_telegram_chatid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_telegram_chatid.Location = new System.Drawing.Point(145, 198);
            this.tb_telegram_chatid.Name = "tb_telegram_chatid";
            this.tb_telegram_chatid.Size = new System.Drawing.Size(791, 25);
            this.tb_telegram_chatid.TabIndex = 9;
            // 
            // tb_telegram_token
            // 
            this.tb_telegram_token.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_telegram_token.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_telegram_token.Location = new System.Drawing.Point(145, 138);
            this.tb_telegram_token.Name = "tb_telegram_token";
            this.tb_telegram_token.Size = new System.Drawing.Size(791, 25);
            this.tb_telegram_token.TabIndex = 8;
            // 
            // lbl_telegram_chatid
            // 
            this.lbl_telegram_chatid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_telegram_chatid.AutoSize = true;
            this.lbl_telegram_chatid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telegram_chatid.Location = new System.Drawing.Point(4, 202);
            this.lbl_telegram_chatid.Name = "lbl_telegram_chatid";
            this.lbl_telegram_chatid.Size = new System.Drawing.Size(108, 17);
            this.lbl_telegram_chatid.TabIndex = 7;
            this.lbl_telegram_chatid.Text = "Telegram Chat ID";
            // 
            // lbl_telegram_token
            // 
            this.lbl_telegram_token.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_telegram_token.AutoSize = true;
            this.lbl_telegram_token.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telegram_token.Location = new System.Drawing.Point(4, 142);
            this.lbl_telegram_token.Name = "lbl_telegram_token";
            this.lbl_telegram_token.Size = new System.Drawing.Size(100, 17);
            this.lbl_telegram_token.TabIndex = 6;
            this.lbl_telegram_token.Text = "Telegram Token";
            // 
            // tbDeepstackUrl
            // 
            this.tbDeepstackUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDeepstackUrl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeepstackUrl.Location = new System.Drawing.Point(145, 78);
            this.tbDeepstackUrl.Name = "tbDeepstackUrl";
            this.tbDeepstackUrl.Size = new System.Drawing.Size(791, 25);
            this.tbDeepstackUrl.TabIndex = 5;
            // 
            // lbl_input
            // 
            this.lbl_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_input.AutoSize = true;
            this.lbl_input.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_input.Location = new System.Drawing.Point(4, 22);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(66, 17);
            this.lbl_input.TabIndex = 1;
            this.lbl_input.Text = "Input Path";
            // 
            // lbl_deepstackurl
            // 
            this.lbl_deepstackurl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_deepstackurl.AutoSize = true;
            this.lbl_deepstackurl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deepstackurl.Location = new System.Drawing.Point(4, 82);
            this.lbl_deepstackurl.Name = "lbl_deepstackurl";
            this.lbl_deepstackurl.Size = new System.Drawing.Size(95, 17);
            this.lbl_deepstackurl.TabIndex = 4;
            this.lbl_deepstackurl.Text = "Deepstack URL";
            // 
            // cb_send_errors
            // 
            this.cb_send_errors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_send_errors.Location = new System.Drawing.Point(145, 304);
            this.cb_send_errors.Name = "cb_send_errors";
            this.cb_send_errors.Size = new System.Drawing.Size(791, 59);
            this.cb_send_errors.TabIndex = 12;
            this.cb_send_errors.Text = "Send Errors and Warnings to Telegram";
            this.cb_send_errors.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Send Errors";
            // 
            // tableLayoutPanel25
            // 
            this.tableLayoutPanel25.ColumnCount = 2;
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel25.Controls.Add(this.btn_open_log, 1, 0);
            this.tableLayoutPanel25.Controls.Add(this.cb_log, 0, 0);
            this.tableLayoutPanel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel25.Location = new System.Drawing.Point(145, 244);
            this.tableLayoutPanel25.Name = "tableLayoutPanel25";
            this.tableLayoutPanel25.RowCount = 1;
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel25.Size = new System.Drawing.Size(791, 53);
            this.tableLayoutPanel25.TabIndex = 14;
            // 
            // cb_log
            // 
            this.cb_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_log.Location = new System.Drawing.Point(3, 3);
            this.cb_log.Name = "cb_log";
            this.cb_log.Size = new System.Drawing.Size(705, 47);
            this.cb_log.TabIndex = 11;
            this.cb_log.Text = "Log everything";
            this.cb_log.UseVisualStyleBackColor = true;
            // 
            // btn_open_log
            // 
            this.btn_open_log.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_open_log.Location = new System.Drawing.Point(714, 15);
            this.btn_open_log.Name = "btn_open_log";
            this.btn_open_log.Size = new System.Drawing.Size(74, 23);
            this.btn_open_log.TabIndex = 2;
            this.btn_open_log.Text = "Open Log";
            this.btn_open_log.UseVisualStyleBackColor = true;
            this.btn_open_log.Click += new System.EventHandler(this.btn_open_log_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Log";
            // 
            // tabCameras
            // 
            this.tabCameras.Controls.Add(this.tableLayoutPanel2);
            this.tabCameras.Location = new System.Drawing.Point(4, 22);
            this.tabCameras.Name = "tabCameras";
            this.tabCameras.Padding = new System.Windows.Forms.Padding(3);
            this.tabCameras.Size = new System.Drawing.Size(946, 436);
            this.tabCameras.TabIndex = 2;
            this.tabCameras.Text = "Cameras";
            this.tabCameras.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0505F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.94949F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(940, 430);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel11, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.lbl_camstats, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(144, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(793, 424);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // lbl_camstats
            // 
            this.lbl_camstats.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_camstats.AutoSize = true;
            this.lbl_camstats.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_camstats.Location = new System.Drawing.Point(3, 12);
            this.lbl_camstats.Name = "lbl_camstats";
            this.lbl_camstats.Size = new System.Drawing.Size(36, 17);
            this.lbl_camstats.TabIndex = 4;
            this.lbl_camstats.Text = "Stats";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.btnCameraSave, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.btnCameraDel, 1, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 384);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(787, 37);
            this.tableLayoutPanel11.TabIndex = 3;
            // 
            // btnCameraDel
            // 
            this.btnCameraDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCameraDel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCameraDel.Location = new System.Drawing.Point(532, 3);
            this.btnCameraDel.Name = "btnCameraDel";
            this.btnCameraDel.Size = new System.Drawing.Size(116, 31);
            this.btnCameraDel.TabIndex = 5;
            this.btnCameraDel.Text = " Delete Camera ";
            this.btnCameraDel.UseVisualStyleBackColor = true;
            this.btnCameraDel.Click += new System.EventHandler(this.btnCameraDel_Click);
            // 
            // btnCameraSave
            // 
            this.btnCameraSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCameraSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCameraSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCameraSave.Location = new System.Drawing.Point(153, 3);
            this.btnCameraSave.Name = "btnCameraSave";
            this.btnCameraSave.Size = new System.Drawing.Size(86, 31);
            this.btnCameraSave.TabIndex = 4;
            this.btnCameraSave.Text = "Save";
            this.btnCameraSave.UseVisualStyleBackColor = false;
            this.btnCameraSave.Click += new System.EventHandler(this.btnCameraSave_Click_1);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 1, 4);
            this.tableLayoutPanel7.Controls.Add(this.lblPrefix, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel12, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel13, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblRelevantObjects, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.lbl_threshold, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel24, 1, 3);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 45);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 5;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(787, 333);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // tableLayoutPanel24
            // 
            this.tableLayoutPanel24.ColumnCount = 6;
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel24.Controls.Add(this.lbl_threshold_lower, 0, 0);
            this.tableLayoutPanel24.Controls.Add(this.tb_threshold_upper, 4, 0);
            this.tableLayoutPanel24.Controls.Add(this.lbl_threshold_upper, 3, 0);
            this.tableLayoutPanel24.Controls.Add(this.tb_threshold_lower, 1, 0);
            this.tableLayoutPanel24.Controls.Add(this.label9, 5, 0);
            this.tableLayoutPanel24.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel24.Location = new System.Drawing.Point(146, 181);
            this.tableLayoutPanel24.Name = "tableLayoutPanel24";
            this.tableLayoutPanel24.RowCount = 1;
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel24.Size = new System.Drawing.Size(637, 29);
            this.tableLayoutPanel24.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(193, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "%";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(510, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "%";
            // 
            // tb_threshold_lower
            // 
            this.tb_threshold_lower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_threshold_lower.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_threshold_lower.Location = new System.Drawing.Point(127, 3);
            this.tb_threshold_lower.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.tb_threshold_lower.MaxLength = 3;
            this.tb_threshold_lower.Name = "tb_threshold_lower";
            this.tb_threshold_lower.Size = new System.Drawing.Size(60, 25);
            this.tb_threshold_lower.TabIndex = 18;
            this.tb_threshold_lower.Leave += new System.EventHandler(this.tb_threshold_lower_Leave);
            // 
            // lbl_threshold_upper
            // 
            this.lbl_threshold_upper.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_threshold_upper.AutoSize = true;
            this.lbl_threshold_upper.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_threshold_upper.Location = new System.Drawing.Point(320, 6);
            this.lbl_threshold_upper.Name = "lbl_threshold_upper";
            this.lbl_threshold_upper.Size = new System.Drawing.Size(73, 17);
            this.lbl_threshold_upper.TabIndex = 21;
            this.lbl_threshold_upper.Text = "Upper limit";
            // 
            // tb_threshold_upper
            // 
            this.tb_threshold_upper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_threshold_upper.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_threshold_upper.Location = new System.Drawing.Point(444, 3);
            this.tb_threshold_upper.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.tb_threshold_upper.MaxLength = 3;
            this.tb_threshold_upper.Name = "tb_threshold_upper";
            this.tb_threshold_upper.Size = new System.Drawing.Size(60, 25);
            this.tb_threshold_upper.TabIndex = 20;
            this.tb_threshold_upper.Leave += new System.EventHandler(this.tb_threshold_upper_Leave);
            // 
            // lbl_threshold_lower
            // 
            this.lbl_threshold_lower.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_threshold_lower.AutoSize = true;
            this.lbl_threshold_lower.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_threshold_lower.Location = new System.Drawing.Point(3, 6);
            this.lbl_threshold_lower.Name = "lbl_threshold_lower";
            this.lbl_threshold_lower.Size = new System.Drawing.Size(71, 17);
            this.lbl_threshold_lower.TabIndex = 19;
            this.lbl_threshold_lower.Text = "Lower limit";
            // 
            // lbl_threshold
            // 
            this.lbl_threshold.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_threshold.AutoSize = true;
            this.lbl_threshold.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_threshold.Location = new System.Drawing.Point(4, 187);
            this.lbl_threshold.Name = "lbl_threshold";
            this.lbl_threshold.Size = new System.Drawing.Size(107, 17);
            this.lbl_threshold.TabIndex = 15;
            this.lbl_threshold.Text = "Confidence limits";
            // 
            // lblRelevantObjects
            // 
            this.lblRelevantObjects.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRelevantObjects.AutoSize = true;
            this.lblRelevantObjects.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelevantObjects.Location = new System.Drawing.Point(4, 116);
            this.lblRelevantObjects.Name = "lblRelevantObjects";
            this.lblRelevantObjects.Size = new System.Drawing.Size(105, 17);
            this.lblRelevantObjects.TabIndex = 1;
            this.lblRelevantObjects.Text = "Relevant Objects";
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 2;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Controls.Add(this.tbName, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.cb_enabled, 1, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(146, 4);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(637, 29);
            this.tableLayoutPanel13.TabIndex = 13;
            // 
            // cb_enabled
            // 
            this.cb_enabled.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_enabled.AutoSize = true;
            this.cb_enabled.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_enabled.Location = new System.Drawing.Point(338, 4);
            this.cb_enabled.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.cb_enabled.Name = "cb_enabled";
            this.cb_enabled.Size = new System.Drawing.Size(232, 21);
            this.cb_enabled.TabIndex = 13;
            this.cb_enabled.Text = "Enable AI Detection for this camera";
            this.cb_enabled.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(20, 3);
            this.tbName.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(278, 25);
            this.tbName.TabIndex = 12;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.tbPrefix, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.lbl_prefix, 1, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(146, 40);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(637, 29);
            this.tableLayoutPanel12.TabIndex = 12;
            // 
            // lbl_prefix
            // 
            this.lbl_prefix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_prefix.AutoSize = true;
            this.lbl_prefix.Location = new System.Drawing.Point(477, 8);
            this.lbl_prefix.Name = "lbl_prefix";
            this.lbl_prefix.Size = new System.Drawing.Size(0, 13);
            this.lbl_prefix.TabIndex = 6;
            // 
            // tbPrefix
            // 
            this.tbPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrefix.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrefix.Location = new System.Drawing.Point(20, 3);
            this.tbPrefix.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.tbPrefix.Name = "tbPrefix";
            this.tbPrefix.Size = new System.Drawing.Size(278, 25);
            this.tbPrefix.TabIndex = 5;
            this.tbPrefix.TextChanged += new System.EventHandler(this.tbPrefix_TextChanged);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(4, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 17);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // lblPrefix
            // 
            this.lblPrefix.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrefix.Location = new System.Drawing.Point(4, 46);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(128, 17);
            this.lblPrefix.TabIndex = 2;
            this.lblPrefix.Text = "Input file begins with";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.cb_telegram, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel20, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(146, 217);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(637, 112);
            this.tableLayoutPanel9.TabIndex = 8;
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.ColumnCount = 3;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel20.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel20.Controls.Add(this.tb_cooldown, 1, 0);
            this.tableLayoutPanel20.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 1;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(631, 31);
            this.tableLayoutPanel20.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(223, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Minutes";
            // 
            // tb_cooldown
            // 
            this.tb_cooldown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_cooldown.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cooldown.Location = new System.Drawing.Point(126, 3);
            this.tb_cooldown.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.tb_cooldown.Name = "tb_cooldown";
            this.tb_cooldown.Size = new System.Drawing.Size(91, 25);
            this.tb_cooldown.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cooldown Time";
            // 
            // cb_telegram
            // 
            this.cb_telegram.AutoSize = true;
            this.cb_telegram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_telegram.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_telegram.Location = new System.Drawing.Point(20, 77);
            this.cb_telegram.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.cb_telegram.Name = "cb_telegram";
            this.cb_telegram.Size = new System.Drawing.Size(614, 32);
            this.cb_telegram.TabIndex = 7;
            this.cb_telegram.Text = "Send alert images to Telegram";
            this.cb_telegram.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel10.Controls.Add(this.lblTriggerUrl, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.tbTriggerUrl, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 40);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(631, 31);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // tbTriggerUrl
            // 
            this.tbTriggerUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTriggerUrl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTriggerUrl.Location = new System.Drawing.Point(126, 3);
            this.tbTriggerUrl.Margin = new System.Windows.Forms.Padding(0, 3, 20, 3);
            this.tbTriggerUrl.Name = "tbTriggerUrl";
            this.tbTriggerUrl.Size = new System.Drawing.Size(485, 25);
            this.tbTriggerUrl.TabIndex = 0;
            this.tbTriggerUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTriggerUrl_KeyDown);
            this.tbTriggerUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbTriggerUrl_KeyUp);
            // 
            // lblTriggerUrl
            // 
            this.lblTriggerUrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTriggerUrl.AutoSize = true;
            this.lblTriggerUrl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriggerUrl.Location = new System.Drawing.Point(20, 7);
            this.lblTriggerUrl.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblTriggerUrl.MinimumSize = new System.Drawing.Size(80, 0);
            this.lblTriggerUrl.Name = "lblTriggerUrl";
            this.lblTriggerUrl.Size = new System.Drawing.Size(91, 17);
            this.lblTriggerUrl.TabIndex = 1;
            this.lblTriggerUrl.Text = "Trigger URL(s)";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Actions";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 5;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.Controls.Add(this.cb_person, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.cb_bicycle, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.cb_motorcycle, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.cb_bear, 4, 2);
            this.tableLayoutPanel8.Controls.Add(this.cb_cow, 4, 1);
            this.tableLayoutPanel8.Controls.Add(this.cb_sheep, 4, 0);
            this.tableLayoutPanel8.Controls.Add(this.cb_horse, 3, 2);
            this.tableLayoutPanel8.Controls.Add(this.cb_bird, 3, 1);
            this.tableLayoutPanel8.Controls.Add(this.cb_dog, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.cb_cat, 2, 2);
            this.tableLayoutPanel8.Controls.Add(this.cb_airplane, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.cb_boat, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.cb_bus, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.cb_truck, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.cb_car, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(146, 76);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(637, 98);
            this.tableLayoutPanel8.TabIndex = 14;
            // 
            // cb_car
            // 
            this.cb_car.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_car.AutoSize = true;
            this.cb_car.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_car.Location = new System.Drawing.Point(147, 5);
            this.cb_car.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.cb_car.Name = "cb_car";
            this.cb_car.Size = new System.Drawing.Size(47, 21);
            this.cb_car.TabIndex = 2;
            this.cb_car.Text = "Car";
            this.cb_car.UseVisualStyleBackColor = true;
            // 
            // cb_truck
            // 
            this.cb_truck.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_truck.AutoSize = true;
            this.cb_truck.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_truck.Location = new System.Drawing.Point(147, 37);
            this.cb_truck.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.cb_truck.Name = "cb_truck";
            this.cb_truck.Size = new System.Drawing.Size(57, 21);
            this.cb_truck.TabIndex = 6;
            this.cb_truck.Text = "Truck";
            this.cb_truck.UseVisualStyleBackColor = true;
            // 
            // cb_bus
            // 
            this.cb_bus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_bus.AutoSize = true;
            this.cb_bus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_bus.Location = new System.Drawing.Point(147, 70);
            this.cb_bus.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.cb_bus.Name = "cb_bus";
            this.cb_bus.Size = new System.Drawing.Size(47, 21);
            this.cb_bus.TabIndex = 4;
            this.cb_bus.Text = "Bus";
            this.cb_bus.UseVisualStyleBackColor = true;
            // 
            // cb_boat
            // 
            this.cb_boat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_boat.AutoSize = true;
            this.cb_boat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_boat.Location = new System.Drawing.Point(274, 5);
            this.cb_boat.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.cb_boat.Name = "cb_boat";
            this.cb_boat.Size = new System.Drawing.Size(53, 21);
            this.cb_boat.TabIndex = 12;
            this.cb_boat.Text = "Boat";
            this.cb_boat.UseVisualStyleBackColor = true;
            // 
            // cb_airplane
            // 
            this.cb_airplane.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_airplane.AutoSize = true;
            this.cb_airplane.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_airplane.Location = new System.Drawing.Point(274, 37);
            this.cb_airplane.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.cb_airplane.Name = "cb_airplane";
            this.cb_airplane.Size = new System.Drawing.Size(75, 21);
            this.cb_airplane.TabIndex = 14;
            this.cb_airplane.Text = "Airplane";
            this.cb_airplane.UseVisualStyleBackColor = true;
            // 
            // cb_cat
            // 
            this.cb_cat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_cat.AutoSize = true;
            this.cb_cat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cat.Location = new System.Drawing.Point(274, 70);
            this.cb_cat.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.cb_cat.Name = "cb_cat";
            this.cb_cat.Size = new System.Drawing.Size(46, 21);
            this.cb_cat.TabIndex = 1;
            this.cb_cat.Text = "Cat";
            this.cb_cat.UseVisualStyleBackColor = true;
            // 
            // cb_dog
            // 
            this.cb_dog.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_dog.AutoSize = true;
            this.cb_dog.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_dog.Location = new System.Drawing.Point(401, 5);
            this.cb_dog.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.cb_dog.Name = "cb_dog";
            this.cb_dog.Size = new System.Drawing.Size(52, 21);
            this.cb_dog.TabIndex = 3;
            this.cb_dog.Text = "Dog";
            this.cb_dog.UseVisualStyleBackColor = true;
            // 
            // cb_bird
            // 
            this.cb_bird.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_bird.AutoSize = true;
            this.cb_bird.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_bird.Location = new System.Drawing.Point(401, 37);
            this.cb_bird.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.cb_bird.Name = "cb_bird";
            this.cb_bird.Size = new System.Drawing.Size(50, 21);
            this.cb_bird.TabIndex = 5;
            this.cb_bird.Text = "Bird";
            this.cb_bird.UseVisualStyleBackColor = true;
            // 
            // cb_horse
            // 
            this.cb_horse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_horse.AutoSize = true;
            this.cb_horse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_horse.Location = new System.Drawing.Point(401, 70);
            this.cb_horse.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.cb_horse.Name = "cb_horse";
            this.cb_horse.Size = new System.Drawing.Size(62, 21);
            this.cb_horse.TabIndex = 7;
            this.cb_horse.Text = "Horse";
            this.cb_horse.UseVisualStyleBackColor = true;
            // 
            // cb_sheep
            // 
            this.cb_sheep.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_sheep.AutoSize = true;
            this.cb_sheep.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sheep.Location = new System.Drawing.Point(528, 5);
            this.cb_sheep.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.cb_sheep.Name = "cb_sheep";
            this.cb_sheep.Size = new System.Drawing.Size(63, 21);
            this.cb_sheep.TabIndex = 9;
            this.cb_sheep.Text = "Sheep";
            this.cb_sheep.UseVisualStyleBackColor = true;
            // 
            // cb_cow
            // 
            this.cb_cow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_cow.AutoSize = true;
            this.cb_cow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cow.Location = new System.Drawing.Point(528, 37);
            this.cb_cow.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.cb_cow.Name = "cb_cow";
            this.cb_cow.Size = new System.Drawing.Size(52, 21);
            this.cb_cow.TabIndex = 11;
            this.cb_cow.Text = "Cow";
            this.cb_cow.UseVisualStyleBackColor = true;
            // 
            // cb_bear
            // 
            this.cb_bear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_bear.AutoSize = true;
            this.cb_bear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_bear.Location = new System.Drawing.Point(528, 70);
            this.cb_bear.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.cb_bear.Name = "cb_bear";
            this.cb_bear.Size = new System.Drawing.Size(53, 21);
            this.cb_bear.TabIndex = 13;
            this.cb_bear.Text = "Bear";
            this.cb_bear.UseVisualStyleBackColor = true;
            // 
            // cb_motorcycle
            // 
            this.cb_motorcycle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_motorcycle.AutoSize = true;
            this.cb_motorcycle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_motorcycle.Location = new System.Drawing.Point(20, 70);
            this.cb_motorcycle.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.cb_motorcycle.Name = "cb_motorcycle";
            this.cb_motorcycle.Size = new System.Drawing.Size(92, 21);
            this.cb_motorcycle.TabIndex = 10;
            this.cb_motorcycle.Text = "Motorcycle";
            this.cb_motorcycle.UseVisualStyleBackColor = true;
            // 
            // cb_bicycle
            // 
            this.cb_bicycle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_bicycle.AutoSize = true;
            this.cb_bicycle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_bicycle.Location = new System.Drawing.Point(20, 37);
            this.cb_bicycle.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.cb_bicycle.Name = "cb_bicycle";
            this.cb_bicycle.Size = new System.Drawing.Size(65, 21);
            this.cb_bicycle.TabIndex = 8;
            this.cb_bicycle.Text = "Bicycle";
            this.cb_bicycle.UseVisualStyleBackColor = true;
            // 
            // cb_person
            // 
            this.cb_person.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_person.AutoSize = true;
            this.cb_person.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_person.Location = new System.Drawing.Point(20, 5);
            this.cb_person.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.cb_person.Name = "cb_person";
            this.cb_person.Size = new System.Drawing.Size(67, 21);
            this.cb_person.TabIndex = 0;
            this.cb_person.Text = "Person";
            this.cb_person.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.list2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCameraAdd, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(135, 424);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnCameraAdd
            // 
            this.btnCameraAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCameraAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCameraAdd.Location = new System.Drawing.Point(20, 379);
            this.btnCameraAdd.Name = "btnCameraAdd";
            this.btnCameraAdd.Size = new System.Drawing.Size(94, 42);
            this.btnCameraAdd.TabIndex = 4;
            this.btnCameraAdd.Text = "Add Camera";
            this.btnCameraAdd.UseVisualStyleBackColor = true;
            this.btnCameraAdd.Click += new System.EventHandler(this.btnCameraAdd_Click);
            // 
            // list2
            // 
            this.list2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list2.GridLines = true;
            this.list2.HideSelection = false;
            this.list2.Location = new System.Drawing.Point(3, 3);
            this.list2.Name = "list2";
            this.list2.Size = new System.Drawing.Size(129, 370);
            this.list2.TabIndex = 1;
            this.list2.UseCompatibleStateImageBehavior = false;
            this.list2.View = System.Windows.Forms.View.Details;
            this.list2.SelectedIndexChanged += new System.EventHandler(this.list2_SelectedIndexChanged);
            this.list2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.list2_KeyDown);
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.tableLayoutPanel1);
            this.tabHistory.Location = new System.Drawing.Point(4, 22);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistory.Size = new System.Drawing.Size(946, 436);
            this.tabHistory.TabIndex = 0;
            this.tabHistory.Text = "History";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel21, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(940, 430);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel19);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Size = new System.Drawing.Size(276, 424);
            this.splitContainer1.SplitterDistance = 316;
            this.splitContainer1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox_filter_camera);
            this.panel1.Controls.Add(this.cb_filter_nosuccess);
            this.panel1.Controls.Add(this.cb_filter_success);
            this.panel1.Controls.Add(this.cb_filter_person);
            this.panel1.Controls.Add(this.cb_filter_vehicle);
            this.panel1.Controls.Add(this.cb_filter_animal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 98);
            this.panel1.TabIndex = 2;
            // 
            // cb_filter_animal
            // 
            this.cb_filter_animal.AutoSize = true;
            this.cb_filter_animal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_filter_animal.Location = new System.Drawing.Point(6, 145);
            this.cb_filter_animal.Name = "cb_filter_animal";
            this.cb_filter_animal.Size = new System.Drawing.Size(162, 21);
            this.cb_filter_animal.TabIndex = 0;
            this.cb_filter_animal.Text = "only alerts with animals";
            this.cb_filter_animal.UseVisualStyleBackColor = true;
            this.cb_filter_animal.CheckedChanged += new System.EventHandler(this.cb_filter_animal_CheckedChanged);
            // 
            // cb_filter_vehicle
            // 
            this.cb_filter_vehicle.AutoSize = true;
            this.cb_filter_vehicle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_filter_vehicle.Location = new System.Drawing.Point(6, 118);
            this.cb_filter_vehicle.Name = "cb_filter_vehicle";
            this.cb_filter_vehicle.Size = new System.Drawing.Size(163, 21);
            this.cb_filter_vehicle.TabIndex = 0;
            this.cb_filter_vehicle.Text = "only alerts with vehicles";
            this.cb_filter_vehicle.UseVisualStyleBackColor = true;
            this.cb_filter_vehicle.CheckedChanged += new System.EventHandler(this.cb_filter_vehicle_CheckedChanged);
            // 
            // cb_filter_person
            // 
            this.cb_filter_person.AutoSize = true;
            this.cb_filter_person.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_filter_person.Location = new System.Drawing.Point(6, 91);
            this.cb_filter_person.Name = "cb_filter_person";
            this.cb_filter_person.Size = new System.Drawing.Size(159, 21);
            this.cb_filter_person.TabIndex = 0;
            this.cb_filter_person.Text = "only alerts with people";
            this.cb_filter_person.UseVisualStyleBackColor = true;
            this.cb_filter_person.CheckedChanged += new System.EventHandler(this.cb_filter_person_CheckedChanged);
            // 
            // cb_filter_success
            // 
            this.cb_filter_success.AutoSize = true;
            this.cb_filter_success.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_filter_success.Location = new System.Drawing.Point(6, 37);
            this.cb_filter_success.Name = "cb_filter_success";
            this.cb_filter_success.Size = new System.Drawing.Size(137, 21);
            this.cb_filter_success.TabIndex = 0;
            this.cb_filter_success.Text = "only relevant alerts";
            this.cb_filter_success.UseVisualStyleBackColor = true;
            this.cb_filter_success.CheckedChanged += new System.EventHandler(this.cb_filter_success_CheckedChanged);
            // 
            // cb_filter_nosuccess
            // 
            this.cb_filter_nosuccess.AutoSize = true;
            this.cb_filter_nosuccess.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_filter_nosuccess.Location = new System.Drawing.Point(6, 64);
            this.cb_filter_nosuccess.Name = "cb_filter_nosuccess";
            this.cb_filter_nosuccess.Size = new System.Drawing.Size(185, 21);
            this.cb_filter_nosuccess.TabIndex = 1;
            this.cb_filter_nosuccess.Text = "only false / irrelevant alerts";
            this.cb_filter_nosuccess.UseVisualStyleBackColor = true;
            this.cb_filter_nosuccess.CheckedChanged += new System.EventHandler(this.cb_filter_nosuccess_CheckedChanged);
            // 
            // comboBox_filter_camera
            // 
            this.comboBox_filter_camera.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_filter_camera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_filter_camera.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_filter_camera.FormattingEnabled = true;
            this.comboBox_filter_camera.Location = new System.Drawing.Point(0, 0);
            this.comboBox_filter_camera.Name = "comboBox_filter_camera";
            this.comboBox_filter_camera.Size = new System.Drawing.Size(268, 25);
            this.comboBox_filter_camera.TabIndex = 2;
            this.comboBox_filter_camera.SelectedIndexChanged += new System.EventHandler(this.comboBox_filter_camera_SelectedIndexChanged);
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 1;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel19.Controls.Add(this.cb_showFilters, 0, 1);
            this.tableLayoutPanel19.Controls.Add(this.list1, 0, 0);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 2;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(276, 316);
            this.tableLayoutPanel19.TabIndex = 0;
            // 
            // list1
            // 
            this.list1.AllowColumnReorder = true;
            this.list1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list1.FullRowSelect = true;
            this.list1.GridLines = true;
            this.list1.HideSelection = false;
            this.list1.Location = new System.Drawing.Point(3, 3);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(270, 280);
            this.list1.TabIndex = 3;
            this.list1.UseCompatibleStateImageBehavior = false;
            this.list1.View = System.Windows.Forms.View.Details;
            this.list1.SelectedIndexChanged += new System.EventHandler(this.list1_SelectedIndexChanged);
            // 
            // cb_showFilters
            // 
            this.cb_showFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_showFilters.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_showFilters.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_showFilters.Location = new System.Drawing.Point(3, 289);
            this.cb_showFilters.MinimumSize = new System.Drawing.Size(0, 27);
            this.cb_showFilters.Name = "cb_showFilters";
            this.cb_showFilters.Size = new System.Drawing.Size(270, 27);
            this.cb_showFilters.TabIndex = 9;
            this.cb_showFilters.Text = "˄ Filter";
            this.cb_showFilters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_showFilters.UseVisualStyleBackColor = true;
            this.cb_showFilters.CheckedChanged += new System.EventHandler(this.cb_showFilters_CheckedChanged);
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel21.ColumnCount = 1;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel21.Controls.Add(this.tableLayoutPanel22, 0, 0);
            this.tableLayoutPanel21.Location = new System.Drawing.Point(285, 3);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 2;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(652, 424);
            this.tableLayoutPanel21.TabIndex = 5;
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel22.ColumnCount = 3;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel22.Controls.Add(this.cb_showObjects, 0, 0);
            this.tableLayoutPanel22.Controls.Add(this.cb_showMask, 0, 0);
            this.tableLayoutPanel22.Controls.Add(this.lbl_objects, 2, 0);
            this.tableLayoutPanel22.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 1;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(646, 36);
            this.tableLayoutPanel22.TabIndex = 7;
            // 
            // lbl_objects
            // 
            this.lbl_objects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_objects.AutoSize = true;
            this.lbl_objects.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_objects.Location = new System.Drawing.Point(261, 9);
            this.lbl_objects.Name = "lbl_objects";
            this.lbl_objects.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbl_objects.Size = new System.Drawing.Size(382, 17);
            this.lbl_objects.TabIndex = 10;
            // 
            // cb_showMask
            // 
            this.cb_showMask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_showMask.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_showMask.AutoSize = true;
            this.cb_showMask.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_showMask.Location = new System.Drawing.Point(3, 4);
            this.cb_showMask.Name = "cb_showMask";
            this.cb_showMask.Size = new System.Drawing.Size(123, 27);
            this.cb_showMask.TabIndex = 8;
            this.cb_showMask.Text = "Show Mask";
            this.cb_showMask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_showMask.UseVisualStyleBackColor = true;
            this.cb_showMask.CheckedChanged += new System.EventHandler(this.cb_showMask_CheckedChanged_1);
            // 
            // cb_showObjects
            // 
            this.cb_showObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_showObjects.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_showObjects.AutoSize = true;
            this.cb_showObjects.Checked = true;
            this.cb_showObjects.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_showObjects.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_showObjects.Location = new System.Drawing.Point(132, 4);
            this.cb_showObjects.Name = "cb_showObjects";
            this.cb_showObjects.Size = new System.Drawing.Size(123, 27);
            this.cb_showObjects.TabIndex = 9;
            this.cb_showObjects.Text = "Show Objects";
            this.cb_showObjects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_showObjects.UseVisualStyleBackColor = true;
            this.cb_showObjects.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cb_showObjects_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(646, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // tabStats
            // 
            this.tabStats.Controls.Add(this.tableLayoutPanel16);
            this.tabStats.Location = new System.Drawing.Point(4, 22);
            this.tabStats.Name = "tabStats";
            this.tabStats.Size = new System.Drawing.Size(946, 436);
            this.tabStats.TabIndex = 5;
            this.tabStats.Text = "Stats";
            this.tabStats.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 2;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel16.Controls.Add(this.tableLayoutPanel23, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.tableLayoutPanel17, 0, 0);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 1;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(946, 436);
            this.tableLayoutPanel16.TabIndex = 0;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 1;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.Controls.Add(this.chart1, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.comboBox1, 0, 0);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 2;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(277, 430);
            this.tableLayoutPanel17.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 25);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.Area3DStyle.Inclination = 35;
            chartArea3.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 36);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series7.IsValueShownAsLabel = true;
            series7.Legend = "Legend1";
            series7.Name = "s1";
            dataPoint1.IsVisibleInLegend = true;
            series7.Points.Add(dataPoint1);
            series7.Points.Add(dataPoint2);
            series7.Points.Add(dataPoint3);
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(271, 391);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Input Rates";
            this.chart1.Titles.Add(title1);
            // 
            // tableLayoutPanel23
            // 
            this.tableLayoutPanel23.ColumnCount = 1;
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel23.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel23.Controls.Add(this.chart_confidence, 0, 2);
            this.tableLayoutPanel23.Controls.Add(this.timeline, 0, 1);
            this.tableLayoutPanel23.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel23.Location = new System.Drawing.Point(286, 3);
            this.tableLayoutPanel23.Name = "tableLayoutPanel23";
            this.tableLayoutPanel23.RowCount = 3;
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel23.Size = new System.Drawing.Size(657, 430);
            this.tableLayoutPanel23.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(651, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "Timeline";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timeline
            // 
            this.timeline.BackColor = System.Drawing.Color.Transparent;
            this.timeline.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.Interval = 3D;
            chartArea2.AxisX.MajorGrid.Interval = 6D;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisX.MajorTickMark.Interval = 1D;
            chartArea2.AxisX.Maximum = 24D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.Title = "Number";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.timeline.ChartAreas.Add(chartArea2);
            this.timeline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeline.Location = new System.Drawing.Point(3, 36);
            this.timeline.Name = "timeline";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series3.Color = System.Drawing.Color.Silver;
            series3.Legend = "Legend1";
            series3.Name = "all";
            series4.BorderWidth = 4;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Green;
            series4.Legend = "Legend1";
            series4.Name = "relevant";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Orange;
            series5.Legend = "Legend1";
            series5.Name = "irrelevant";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.OrangeRed;
            series6.Legend = "Legend1";
            series6.Name = "falses";
            this.timeline.Series.Add(series3);
            this.timeline.Series.Add(series4);
            this.timeline.Series.Add(series5);
            this.timeline.Series.Add(series6);
            this.timeline.Size = new System.Drawing.Size(651, 176);
            this.timeline.TabIndex = 6;
            // 
            // chart_confidence
            // 
            this.chart_confidence.BackColor = System.Drawing.Color.Transparent;
            this.chart_confidence.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Interval = 10D;
            chartArea1.AxisX.MajorGrid.Interval = 6D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorTickMark.Interval = 1D;
            chartArea1.AxisX.Maximum = 100D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Alert confidence";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.Title = "Frequency";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart_confidence.ChartAreas.Add(chartArea1);
            this.chart_confidence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart_confidence.Location = new System.Drawing.Point(3, 251);
            this.chart_confidence.Name = "chart_confidence";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Orange;
            series1.Name = "no alert";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "alert";
            this.chart_confidence.Series.Add(series1);
            this.chart_confidence.Series.Add(series2);
            this.chart_confidence.Size = new System.Drawing.Size(651, 176);
            this.chart_confidence.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 218);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(651, 27);
            this.label8.TabIndex = 9;
            this.label8.Text = "Frequencies of alert result confidences";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.tableLayoutPanel14);
            this.tabOverview.Location = new System.Drawing.Point(4, 22);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.Size = new System.Drawing.Size(946, 436);
            this.tabOverview.TabIndex = 4;
            this.tabOverview.Text = "Overview";
            this.tabOverview.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel14.ColumnCount = 1;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.Controls.Add(this.tableLayoutPanel15, 0, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(946, 436);
            this.tableLayoutPanel14.TabIndex = 3;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 1;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel15.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel15.Controls.Add(this.lbl_version, 0, 5);
            this.tableLayoutPanel15.Controls.Add(this.lbl_errors, 0, 3);
            this.tableLayoutPanel15.Controls.Add(this.lbl_info, 0, 4);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 6;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(938, 428);
            this.tableLayoutPanel15.TabIndex = 0;
            // 
            // lbl_info
            // 
            this.lbl_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(3, 375);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(932, 29);
            this.lbl_info.TabIndex = 8;
            this.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_errors
            // 
            this.lbl_errors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_errors.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_errors.Location = new System.Drawing.Point(3, 343);
            this.lbl_errors.Name = "lbl_errors";
            this.lbl_errors.Size = new System.Drawing.Size(932, 32);
            this.lbl_errors.TabIndex = 7;
            this.lbl_errors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_errors.Visible = false;
            this.lbl_errors.Click += new System.EventHandler(this.lbl_errors_Click);
            // 
            // lbl_version
            // 
            this.lbl_version.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_version.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_version.Location = new System.Drawing.Point(3, 404);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(932, 24);
            this.lbl_version.TabIndex = 6;
            this.lbl_version.Text = "Version 1.67";
            this.lbl_version.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(60, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(818, 2);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(3, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(932, 92);
            this.label2.TabIndex = 3;
            this.label2.Text = "Running";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(3, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(932, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOverview);
            this.tabControl1.Controls.Add(this.tabStats);
            this.tabControl1.Controls.Add(this.tabHistory);
            this.tabControl1.Controls.Add(this.tabCameras);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(954, 462);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);
            // 
            // Shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(954, 462);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(970, 500);
            this.Name = "Shell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AI Tool";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabSettings.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            this.tableLayoutPanel25.ResumeLayout(false);
            this.tabCameras.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel24.ResumeLayout(false);
            this.tableLayoutPanel24.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel20.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tabHistory.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel22.ResumeLayout(false);
            this.tableLayoutPanel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabStats.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel23.ResumeLayout(false);
            this.tableLayoutPanel23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_confidence)).EndInit();
            this.tabOverview.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel25;
        private System.Windows.Forms.Button btn_open_log;
        private System.Windows.Forms.CheckBox cb_log;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cb_send_errors;
        private System.Windows.Forms.Label lbl_deepstackurl;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.TextBox tbDeepstackUrl;
        private System.Windows.Forms.Label lbl_telegram_token;
        private System.Windows.Forms.Label lbl_telegram_chatid;
        private System.Windows.Forms.TextBox tb_telegram_token;
        private System.Windows.Forms.TextBox tb_telegram_chatid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btn_input_path;
        private System.Windows.Forms.Button BtnSettingsSave;
        private System.Windows.Forms.TabPage tabCameras;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListView list2;
        private System.Windows.Forms.Button btnCameraAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.CheckBox cb_person;
        private System.Windows.Forms.CheckBox cb_bicycle;
        private System.Windows.Forms.CheckBox cb_motorcycle;
        private System.Windows.Forms.CheckBox cb_bear;
        private System.Windows.Forms.CheckBox cb_cow;
        private System.Windows.Forms.CheckBox cb_sheep;
        private System.Windows.Forms.CheckBox cb_horse;
        private System.Windows.Forms.CheckBox cb_bird;
        private System.Windows.Forms.CheckBox cb_dog;
        private System.Windows.Forms.CheckBox cb_cat;
        private System.Windows.Forms.CheckBox cb_airplane;
        private System.Windows.Forms.CheckBox cb_boat;
        private System.Windows.Forms.CheckBox cb_bus;
        private System.Windows.Forms.CheckBox cb_truck;
        private System.Windows.Forms.CheckBox cb_car;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label lblTriggerUrl;
        private System.Windows.Forms.TextBox tbTriggerUrl;
        private System.Windows.Forms.CheckBox cb_telegram;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_cooldown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TextBox tbPrefix;
        private System.Windows.Forms.Label lbl_prefix;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.CheckBox cb_enabled;
        private System.Windows.Forms.Label lblRelevantObjects;
        private System.Windows.Forms.Label lbl_threshold;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel24;
        private System.Windows.Forms.Label lbl_threshold_lower;
        private System.Windows.Forms.TextBox tb_threshold_upper;
        private System.Windows.Forms.Label lbl_threshold_upper;
        private System.Windows.Forms.TextBox tb_threshold_lower;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Button btnCameraSave;
        private System.Windows.Forms.Button btnCameraDel;
        private System.Windows.Forms.Label lbl_camstats;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel22;
        private System.Windows.Forms.CheckBox cb_showObjects;
        private System.Windows.Forms.CheckBox cb_showMask;
        private System.Windows.Forms.Label lbl_objects;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private System.Windows.Forms.CheckBox cb_showFilters;
        private System.Windows.Forms.ListView list1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_filter_camera;
        private System.Windows.Forms.CheckBox cb_filter_nosuccess;
        private System.Windows.Forms.CheckBox cb_filter_success;
        private System.Windows.Forms.CheckBox cb_filter_person;
        private System.Windows.Forms.CheckBox cb_filter_vehicle;
        private System.Windows.Forms.CheckBox cb_filter_animal;
        private System.Windows.Forms.TabPage tabStats;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel23;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_confidence;
        private System.Windows.Forms.DataVisualization.Charting.Chart timeline;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabOverview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Label lbl_errors;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

