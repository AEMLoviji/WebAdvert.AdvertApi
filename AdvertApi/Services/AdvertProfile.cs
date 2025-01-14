﻿using AdvertApi.Models;
using AutoMapper;

namespace AdvertApi.Services;

public class AdvertProfile : Profile
{
    public AdvertProfile()
    {
        CreateMap<CreateAdvertRequest, AdvertDbModel>().ReverseMap();
    }
}
