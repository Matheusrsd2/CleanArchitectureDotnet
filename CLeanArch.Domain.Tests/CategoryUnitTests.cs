using CleanArch.Domain.Entities;
using CleanArch.Domain.Validation;
using FluentAssertions;
using System;
using Xunit;

namespace CLeanArch.Domain.Tests
{
    public class CategoryUnitTests
    {
        [Fact(DisplayName = "Criar Categoria com estado valido")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Categoria(-2, "Nome");
            action.Should()
                .NotThrow<DomainExceptionValidation>();
        }
    }
}