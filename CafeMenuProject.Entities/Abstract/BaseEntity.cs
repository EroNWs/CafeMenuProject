using System.ComponentModel.DataAnnotations.Schema;

namespace CafeMenuProject.Domain.Abstract;

/// <summary>
/// Base class for entities with common properties.
/// </summary>
public abstract class BaseEntity
{
    /// <summary>
    /// Gets or sets the unique identifier for the entity.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the entity was created.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// Gets or sets the user who created the entity.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string CreatorUserId { get; set; }


    /// <summary>
    /// Initializes a new instance of the <see cref="BaseEntity"/> class.
    /// </summary>
    public BaseEntity()
    {
        Id = default;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseEntity"/> class with the specified ID.
    /// </summary>
    /// <param name="id">The unique identifier for the entity.</param>
    public BaseEntity(Guid id)
    {
        Id = id;
    }



}
