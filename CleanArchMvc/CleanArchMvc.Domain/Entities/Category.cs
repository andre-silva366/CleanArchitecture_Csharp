using CleanArchMVC.Domain.Validation;
using System.Collections.Generic;

namespace CleanArchMVC.Domain.Entities
{
    public sealed class Category : Entity
    {
        public string Name { get; private set; }

        public Category(string name)
        {
            ValidateDomain(name);
        }

        // apenas para poder popular a tabela
        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id <= 0, "Invalid Id value.");
            Id = id;
            ValidateDomain(name);
        }

        public void Update(string name)
        {
            ValidateDomain(name);
        }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name. Name is required.");

            DomainExceptionValidation.When(name.Length < 3, "Invalid name, too short, minimu 3 characters.");

            Name = name;
        }

        public ICollection<Product> Products { get; set; }

    }
}
