namespace Core.DTOs
{
	public struct TextDto
	{
		public string Text { get; }

		public TextDto(string text)
		{
			Text = text;
		}
	}
}