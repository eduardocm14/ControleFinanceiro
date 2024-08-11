using System;
using System.Windows.Forms;

public class CustomMessageBox : Form
{
    public enum CustomDialogResult
    {
        PDF,
        ODS,
        Cancel
    }

    private Button btnPDF;
    private Button btnODS;
    private Button btnCancel;
    private Label lblMessage;
    private CustomDialogResult result;

    public CustomMessageBox()
    {
        btnPDF = new Button() { Text = "Salvar em PDF", DialogResult = DialogResult.OK, Left = 10, Width = 100, Top = 50 };
        btnODS = new Button() { Text = "Salvar em ODS", DialogResult = DialogResult.OK, Left = 120, Width = 100, Top = 50 };
        btnCancel = new Button() { Text = "Cancelar", DialogResult = DialogResult.Cancel, Left = 230, Width = 100, Top = 50 };
        lblMessage = new Label() { Text = "Você deseja salvar em PDF, ODS ou cancelar?", Left = 10, Top = 10, Width = 320 };

        btnPDF.Click += (sender, e) => { result = CustomDialogResult.PDF; this.Close(); };
        btnODS.Click += (sender, e) => { result = CustomDialogResult.ODS; this.Close(); };
        btnCancel.Click += (sender, e) => { result = CustomDialogResult.Cancel; this.Close(); };

        this.Controls.Add(btnPDF);
        this.Controls.Add(btnODS);
        this.Controls.Add(btnCancel);
        this.Controls.Add(lblMessage);
        this.StartPosition = FormStartPosition.CenterParent;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.ClientSize = new System.Drawing.Size(350, 100);
        this.AcceptButton = btnPDF;
        this.CancelButton = btnCancel;
    }

    public static CustomDialogResult Show(string message)
    {
        using (CustomMessageBox box = new CustomMessageBox())
        {
            box.lblMessage.Text = message;
            box.ShowDialog();
            return box.result;
        }
    }
}
