﻿using Forge.Forms.Annotations;
using Forge.Forms.Annotations.Content;
using Forge.Forms.Annotations.Display;
using Forge.Forms.Interfaces;
using MaterialDesignThemes.Wpf;
using PropertyChanged;

namespace Forge.Forms.Demo.Models
{
    [Title("Login to continue")]
    [Action("cancel", "CANCEL", IsCancel = true)]
    [Action("login", "LOG IN", IsLoading = "{Binding Loading}", IsDefault = true)]
    [AddINotifyPropertyChangedInterface]
    public class Login : IActionHandler
    {
        // Enums may be deserialized from strings.
        [Field(Icon = "Account")]
        public string Username { get; set; }

        // Or be dynamically assigned...
        [Field(Icon = "{Property PasswordIcon}")]
        [Password]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

        public bool Loading { get; set; }

        public PackIconKind PasswordIcon => PackIconKind.Key;

        /// <inheritdoc />
        public void HandleAction(object model, string action, object parameter)
        {
            Loading = !Loading;
        }
    }
}