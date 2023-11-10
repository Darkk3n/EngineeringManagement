namespace EngineeringManagement.UI.Forms.ExceptionHandler
{
    public partial class ExceptionHandlerForm : Form
    {
        private readonly Exception exception;
        public ExceptionHandlerForm(Exception exception)
        {
            this.exception = exception;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            txtEx.Text = $"{exception.Message}\n\n\n{exception.InnerException}";
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();
    }
}