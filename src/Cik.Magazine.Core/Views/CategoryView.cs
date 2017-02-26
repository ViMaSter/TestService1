﻿using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Cik.Magazine.Core.Views
{
    [Serializable]
    public class ListCategoryViewRequest
    {
    }

    [Serializable]
    public class CategoryViewRequest
    {
        public CategoryViewRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }

    public class CategoryViewResponse
    {
        [BsonId]
        public Guid Id { get; set; }

        [BsonRepresentation(BsonType.String)]
        public string Name { get; set; }
    }

    [Serializable]
    public class CategoryModel
    {
        [Required]
        public string Name { get; set; }

        public Guid ParentId { get; set; }
    }
}