namespace lab_4
{
    internal class Magazine : LibraryItem
    {
        private string mtit;
        private string maut;
        private int issue;

        public Magazine(string mtit, string maut, int issue)
        {
            this.mtit = mtit;
            this.maut = maut;
            this.issue = issue;
        }
    }
}