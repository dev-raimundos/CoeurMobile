using MudBlazor;

namespace CoeurMobile.App.Core.Theme;

public static class AppTheme
{
    public static MudTheme Theme => new()
    {
        PaletteLight = new PaletteLight
        {
            Primary = "#5F6135",
            PrimaryContrastText = "#FFFFFF",
            PrimaryLighten = "#E5E6AE",
            PrimaryDarken = "#47491F",

            Secondary = "#755845",
            SecondaryContrastText = "#FFFFFF",
            SecondaryLighten = "#FFDCC6",
            SecondaryDarken = "#5B412F",

            Tertiary = "#8A5022",
            TertiaryContrastText = "#FFFFFF",
            TertiaryLighten = "#FFDCC6",
            TertiaryDarken = "#6E390C",

            Info = "#2196F3",
            InfoContrastText = "#FFFFFF",
            InfoLighten = "#47A7F5",
            InfoDarken = "#0C80DF",

            Success = "#00C853",
            SuccessContrastText = "#FFFFFF",
            SuccessLighten = "#00EB62",
            SuccessDarken = "#00A344",

            Warning = "#FF9800",
            WarningContrastText = "#FFFFFF",
            WarningLighten = "#FFA724",
            WarningDarken = "#D68100",

            Error = "#D32F2F",
            ErrorContrastText = "#FFFFFF",
            ErrorLighten = "#FFDAD6",
            ErrorDarken = "#93000A",

            Black = "#272C34",
            White = "#FFFFFF",
            Dark = "#424242",
            DarkContrastText = "#FFFFFF",
            DarkLighten = "#575757",
            DarkDarken = "#2E2E2E",

            Background = "#FFF8F5",
            BackgroundGray = "#FBEBE2",
            Surface = "#FFF8F5",
            AppbarBackground = "#5F6135",
            AppbarText = "#FFFFFF",
            DrawerBackground = "#FFF1EA",
            DrawerText = "#221A15",
            DrawerIcon = "#52443B",

            TextPrimary = "#221A15",
            TextSecondary = "#221A158A",
            TextDisabled = "#221A1561",
            ActionDefault = "#221A158A",
            ActionDisabled = "#221A1542",
            ActionDisabledBackground = "#221A151F",

            Divider = "#D7C3B7",
            DividerLight = "#221A15CC",
            LinesDefault = "#221A151F",
            LinesInputs = "#84746A",
            TableLines = "#D7C3B7",
            TableStriped = "#221A1505",
            TableHover = "#221A150A",
            Skeleton = "#221A151C",

            GrayDefault = "#9E9E9E",
            GrayLight = "#BDBDBD",
            GrayLighter = "#E0E0E0",
            GrayDark = "#757575",
            GrayDarker = "#616161",

            OverlayDark = "#21212180",
            OverlayLight = "#FFFFFF80",
            BorderOpacity = 1,
            HoverOpacity = 0.06,
            RippleOpacity = 0.1,
            RippleOpacitySecondary = 0.2,
        },
        PaletteDark = new PaletteDark
        {
            Primary = "#C8CA94",
            PrimaryContrastText = "#31320B",
            PrimaryLighten = "#E5E6AE",
            PrimaryDarken = "#47491F",

            Secondary = "#E4BFA8",
            SecondaryContrastText = "#422B1B",
            SecondaryLighten = "#FFDCC6",
            SecondaryDarken = "#5B412F",

            Tertiary = "#FFB785",
            TertiaryContrastText = "#502500",
            TertiaryLighten = "#FFDCC6",
            TertiaryDarken = "#6E390C",

            Info = "#3299FF",
            InfoContrastText = "#FFFFFF",
            InfoLighten = "#5CADFF",
            InfoDarken = "#0A85FF",

            Success = "#0BBA83",
            SuccessContrastText = "#FFFFFF",
            SuccessLighten = "#0DDE9C",
            SuccessDarken = "#099A6C",

            Warning = "#FFA800",
            WarningContrastText = "#FFFFFF",
            WarningLighten = "#FFB624",
            WarningDarken = "#D68F00",

            Error = "#FF5449",
            ErrorContrastText = "#690005",
            ErrorLighten = "#FFDAD6",
            ErrorDarken = "#93000A",

            Black = "#27272F",
            White = "#FFFFFF",
            Dark = "#27272F",
            DarkContrastText = "#FFFFFF",
            DarkLighten = "#383843",
            DarkDarken = "#17171C",

            Background = "#000000",
            BackgroundGray = "#261E19",
            Surface = "#19120D",
            AppbarBackground = "#19120D",
            AppbarText = "#F0DFD6B3",
            DrawerBackground = "#261E19",
            DrawerText = "#F0DFD680",
            DrawerIcon = "#F0DFD680",

            TextPrimary = "#F0DFD6B3",
            TextSecondary = "#F0DFD680",
            TextDisabled = "#F0DFD633",
            ActionDefault = "#D7C3B7",
            ActionDisabled = "#F0DFD642",
            ActionDisabledBackground = "#F0DFD61F",

            Divider = "#F0DFD61F",
            DividerLight = "#F0DFD60F",
            LinesDefault = "#F0DFD61F",
            LinesInputs = "#F0DFD64D",
            TableLines = "#F0DFD61F",
            TableStriped = "#F0DFD633",
            TableHover = "#F0DFD60A",
            Skeleton = "#F0DFD61C",

            GrayDefault = "#9E9E9E",
            GrayLight = "#BDBDBD",
            GrayLighter = "#E0E0E0",
            GrayDark = "#757575",
            GrayDarker = "#616161",

            OverlayDark = "#21212180",
            OverlayLight = "#FFFFFF80",
            BorderOpacity = 1,
            HoverOpacity = 0.06,
            RippleOpacity = 0.1,
            RippleOpacitySecondary = 0.2,
        }
    };
}
