namespace OrchardCore.Data.Documents
{
    public class BaseDocument : IDocument
    {
        /// <summary>
        /// The <see cref="IDocument.Identifier"/>.
        /// </summary>
        public string Identifier { get; set; }
    }
}
