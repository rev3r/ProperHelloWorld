using Core.Entities;

namespace Core.Interfaces
{
	public interface ITextRepository
	{
		TextEntity GetWelcomeText();
	}
}