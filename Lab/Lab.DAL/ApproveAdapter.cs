namespace Lab.DAL
{
    public class ApproveAdapter : IApproveAdapter
    {
        public string GetStatus()
        {
            var approve = new Lab.DAL.Service.Approve();
            return approve.GetStatus();
        }
    }
}