namespace TestWinFormsHybridBlazorPublish;

partial class Form1
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
        this.blazorWebView = new Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView();
        this.SuspendLayout();
        // 
        // blazorWebView
        // 
        this.blazorWebView.Dock = System.Windows.Forms.DockStyle.Fill;
        this.blazorWebView.Location = new System.Drawing.Point(0, 0);
        this.blazorWebView.Name = "blazorWebView";
        this.blazorWebView.Size = new System.Drawing.Size(500, 810);
        this.blazorWebView.TabIndex = 0;
        this.blazorWebView.Text = "Form1";
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(500, 810);
        this.Controls.Add(this.blazorWebView);
        this.Name = "Form1";
        this.Text = "Form1";
        this.ResumeLayout(false);
    }

    #endregion
    
    private Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView blazorWebView;
}