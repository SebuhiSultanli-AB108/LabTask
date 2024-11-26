﻿using Microsoft.AspNetCore.Mvc;
using Pronia.BL.Services.Abstraction;
using Pronia.DAL.Models;

namespace Pronia.MVC.Areas.Admin.Controllers;

[Area("Admin")]
public class DashboardController : Controller
{
    private readonly ISliderItemService _sliderItemService;

    public DashboardController(ISliderItemService sliderItemService)
    {
        _sliderItemService = sliderItemService;
    }

    public async Task<IActionResult> Index()
    {
        List<SliderItem> sliderItems = await _sliderItemService.GetAllSliderItemsAsync();
        return View(sliderItems);
    }
}
