using System;

namespace CoreApi.Models.DomainModel.Interface
{
    public interface IPersistentEntity
    {
        Guid Id { get; set; }
    }
}