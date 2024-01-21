﻿using JMayer.Example.WebAssemblyBlazor.Client.Components.Base;
using JMayer.Example.WebAssemblyBlazor.Client.Pages.Assets.Dialogs;
using JMayer.Example.WebAssemblyBlazor.Shared.Data.Assets;
using JMayer.Example.WebAssemblyBlazor.Shared.HTTP.DataLayer.Assets;

namespace JMayer.Example.WebAssemblyBlazor.Client.Pages.Assets;

/// <summary>
/// The class manages user interactions with the AssetSearch.razor page.
/// </summary>
public class AssetSearchBase : SearchBase<Asset, IAssetDataLayer, NewAssetDialog>
{
}
