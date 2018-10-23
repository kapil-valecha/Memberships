﻿using Memberships.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Memberships.Controllers
{
    [Authorize]
        public class ProductContentController : Controller
        {
            public async Task<ActionResult> Index(int id)
            {
                var userId = Request.IsAuthenticated ? HttpContext.GetUserId() : null;
                var sections = await SectionExtensions.GetProductSectionsAsync(id, userId);

                return View(sections);
            }

            public async Task<ActionResult> Content(int productId, int itemId)
            {
                var model = await SectionExtensions.GetContentAsync(productId, itemId);
                return View("Content", model);
            }

        }
    }