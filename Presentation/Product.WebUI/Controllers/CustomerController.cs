﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Product.Application.Features.CQRS.Commands.CategoryCommands;
using Product.Application.Features.CQRS.Handlers.CategoryHandlers;
using Product.Application.Features.Mediator.Commands.CustomerCommands;
using Product.Application.Features.Mediator.Queries.CustomerQueries;

namespace Product.WebUI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetCustomerQuery()); // Send() metodu bizim mediatordaki handlerlarımızı tetikler
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateCustomer()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CreateCustomerCommand createCustomerCommand)
        {
            await _mediator.Send(createCustomerCommand);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateCustomer(int id)
        {
            var value = await _mediator.Send(new GetCustomerByIdQuery(id));
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCustomer(UpdateCustomerCommand updateCustomerCommand)
        {
            await _mediator.Send(updateCustomerCommand);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            
            await _mediator.Send(new RemoveCustomerCommand(id));
            return RedirectToAction("Index");
        }
    }
}