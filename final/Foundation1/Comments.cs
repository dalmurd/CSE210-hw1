class Comments
{
    public string comment_text;
    public string commenter_name;

    public Comments(string text, string name)
    {
        comment_text = text;
        commenter_name = name;
    }

    List<string> _comments = new List<string>();

    public void AddComment(string comment)
    { _comments.Add(comment);}

    public List<string> GetComments()
    {return _comments;}

    public void GetName(string name)
    {commenter_name = name;}

}