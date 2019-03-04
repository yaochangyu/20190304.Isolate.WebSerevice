using System.Collections.Generic;

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

            var lookup = new Dictionary<string, string>()
            {
                {"99","成功"},
                {"98","暫止"},

            };
            return lookup[status];
        }
    }
}