namespace BlazorDSL
{
    public static class HtmlExtensions
    {
        public static Node videoPlayer(params Node[] inner)
            => new TagNode("video-player", inner);
    }
}
