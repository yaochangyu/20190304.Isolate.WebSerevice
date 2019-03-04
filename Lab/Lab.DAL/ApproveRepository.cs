namespace Lab.DAL
{
    public class ApproveRepository
    {
        private IApproveAdapter _adapter;

        public IApproveAdapter Adapter
        {
            get
            {
                if (this._adapter == null)
                {
                    this._adapter = new ApproveAdapter();
                }
                return this._adapter;
            }
            set => this._adapter = value;
        }

        public string GetStatus()
        {
            var status = this.Adapter.GetStatus();
            if (status == "99")
            {
                return "成功";
            }

            return null;
        }
    }
}