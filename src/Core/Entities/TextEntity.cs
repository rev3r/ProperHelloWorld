namespace Core.Entities
{
	public struct TextEntity
	{
		public string Text { get; }

		public TextEntity(string text)
		{
			Text = text;
		}
	}
}