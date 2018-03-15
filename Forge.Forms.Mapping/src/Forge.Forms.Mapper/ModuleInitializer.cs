﻿using Forge.Forms.Controls;
using Forge.Forms.FormBuilding.Defaults;
using Forge.Forms.Mapper.Interceptors;

namespace Forge.Forms.Mapper
{
    public static class ModuleInitializer
    {
        public static void Initialize()
        {
            Proxier.Mappers.Maps.ProxierMapper.InitializeMapperClasses();
            DynamicForm.InterceptorChain.Add(new MapperInterceptor());
            ActionElement.InterceptorChain.Add(new MapperActionInterceptor());
        }
    }
}