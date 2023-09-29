﻿using CafeMenuProject.Domain.Entities;
using CafeMenuProject.Mapper.BaseMapper;
using CafeMenuProject.ViewModel.Concrete.Create;

namespace CafeMenuProject.Mapper.Abstract.CreateMapper;

/// <summary>
/// Interface for mapping operations between Category entities and CategoryCreateVM view models.
/// Inherits from IBaseMapper for basic mapping functionalities.
/// </summary>
public interface ICategoryCreateMapper : IBaseMapper<Category, CategoryCreateVM>
{
}
