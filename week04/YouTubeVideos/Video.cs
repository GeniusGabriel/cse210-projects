public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();

    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public string GetDisplayText()
    {
        return $"Title: {_title}\nAuthor: {_author}\nLength: {_lengthInSeconds} seconds\n";
    }
    public string GetComments()
    {
        string commentsData = "";
        foreach (Comment comment in _comments)
        {
            commentsData += $"Commenter: {comment.GetCommenterName()} Comment: {comment.GetCommentText()}\n";
        }
        return commentsData;
    }
    public int GetCommentCount()
    {
        return _comments.Count;
    }
}
