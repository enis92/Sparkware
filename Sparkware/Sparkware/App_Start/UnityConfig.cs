﻿using Microsoft.Practices.Unity;
using Sparkware.BL;
using System;

namespace Sparkware.App_Start {
    public class UnityConfig {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() => {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        public static IUnityContainer GetConfiguredContainer() {
            return container.Value;
        }
        #endregion

        public static void RegisterTypes(IUnityContainer container) {
            container.RegisterType<IUsersManager, UsersManager>();
        }
    }
}