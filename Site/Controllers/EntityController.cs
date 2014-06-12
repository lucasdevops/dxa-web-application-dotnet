﻿using Sdl.Web.Mvc;
using Sdl.Web.Mvc.Common;

namespace Site.Controllers
{
    public class EntityController : BaseController
    {
        public EntityController(IContentProvider contentProvider, IRenderer renderer)
        {
            ContentProvider = contentProvider;
            Renderer = renderer;
        }
    }
}
