public class Comment
{
    private string _commenterName;
    private string _commentText;

    public Comment(string name, string text)
    {
        _commenterName = name;
        _commentText = text;
    }
    public string GetCommenterName()
    {
        return _commenterName;
    }
    public string GetCommentText()
    {
        return _commentText;
    }
    public void SetCommenterName(string name)
    {
        _commenterName = name;
    }
    public void SetCommentText(string text)
    {
        _commentText = text;
    }
}