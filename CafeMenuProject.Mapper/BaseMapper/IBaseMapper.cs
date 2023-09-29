namespace CafeMenuProject.Mapper.BaseMapper;

/// <summary>
/// Represents an interface for a base mapper to convert one type to another.
/// </summary>
/// <typeparam name="T">The target type to convert to.</typeparam>
/// <typeparam name="V">The source type to convert from.</typeparam>
public interface IBaseMapper<T, V>
{

	/// <summary>
	/// Converts a source object of type V to a target object of type T.
	/// </summary>
	/// <param name="model">The source object to be converted.</param>
	/// <returns>The converted target object.</returns>
	T GeneralConvertor(V model);


}
