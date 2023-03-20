﻿// Copyright (c) Microsoft Corporation and Contributors
// Licensed under the MIT license.

using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml;

namespace DevHome.SetupFlow.RepoConfig.ViewModels;

/// <summary>
/// View model to handle the dialog when users want to edit the clone path from the repo review page.
/// </summary>
public partial class EditClonePathViewModel : ObservableObject
{
    /// <summary>
    /// COntrols if the error text should be shown.
    /// </summary>
    [ObservableProperty]
    private Visibility _showErrorTextBox;

    /// <summary>
    /// Controls if the primary button should be enabled.
    /// </summary>
    [ObservableProperty]
    private bool _isPrimaryButtonEnabled;

    public EditClonePathViewModel()
    {
        ShowErrorTextBox = Visibility.Collapsed;
        IsPrimaryButtonEnabled = false;
    }
}
