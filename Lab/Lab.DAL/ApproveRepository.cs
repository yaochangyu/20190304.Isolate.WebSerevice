namespace Lab.DAL
{
    public class ApproveRepository
    {
        public string GetStatus()
        {
            IApproveAdapter adapter = new ApproveAdapter();
            var status = adapter.GetStatus();
            if (status == "99")
            {
                return "成功";
            }

            return null;
        }
    }
}