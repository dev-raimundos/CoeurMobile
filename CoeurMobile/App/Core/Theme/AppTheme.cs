using MudBlazor;

namespace CoeurMobile.App.Core.Theme;

public static class AppTheme
{
    private static readonly string[] FontFamily = ["Outfit", "Helvetica", "Arial", "sans-serif"];

    public static MudTheme Theme => new()
    {
        Typography = new Typography
        {
            Default = new DefaultTypography { FontFamily = FontFamily },
            H1 = new H1Typography { FontFamily = FontFamily },
            H2 = new H2Typography { FontFamily = FontFamily },
            H3 = new H3Typography { FontFamily = FontFamily },
            H4 = new H4Typography { FontFamily = FontFamily },
            H5 = new H5Typography { FontFamily = FontFamily },
            H6 = new H6Typography { FontFamily = FontFamily },
            Subtitle1 = new Subtitle1Typography { FontFamily = FontFamily },
            Subtitle2 = new Subtitle2Typography { FontFamily = FontFamily },
            Body1 = new Body1Typography { FontFamily = FontFamily },
            Body2 = new Body2Typography { FontFamily = FontFamily },
            Button = new ButtonTypography { FontFamily = FontFamily },
            Caption = new CaptionTypography { FontFamily = FontFamily },
            Overline = new OverlineTypography { FontFamily = FontFamily },
        },
        PaletteLight = new PaletteLight
        {
            Primary = "#007A55",
            PrimaryContrastText = "#ECFDF5",
            PrimaryLighten = "#00BC7D",
            PrimaryDarken = "#006045",

            Secondary = "#F4F4F5",
            SecondaryContrastText = "#18181B",
            SecondaryLighten = "#FBFBFB",
            SecondaryDarken = "#CFCFD0",

            Tertiary = "#F4F4F0",
            TertiaryContrastText = "#1D1D16",
            TertiaryLighten = "#FBFBF9",
            TertiaryDarken = "#CFCFCC",

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

            Error = "#E7000B",
            ErrorContrastText = "#FFFFFF",
            ErrorLighten = "#FBD9DA",
            ErrorDarken = "#960007",

            Black = "#272C34",
            White = "#FFFFFF",
            Dark = "#424242",
            DarkContrastText = "#FFFFFF",
            DarkLighten = "#575757",
            DarkDarken = "#2E2E2E",

            Background = "#FFFFFF",
            BackgroundGray = "#F4F4F0",
            Surface = "#FFFFFF",
            AppbarBackground = "#007A55",
            AppbarText = "#ECFDF5",
            DrawerBackground = "#FBFBF9",
            DrawerText = "#0C0C09",
            DrawerIcon = "#1D1D16",

            TextPrimary = "#0C0C09",
            TextSecondary = "#7C7C67",
            TextDisabled = "#0C0C0961",
            ActionDefault = "#0C0C098A",
            ActionDisabled = "#0C0C0942",
            ActionDisabledBackground = "#0C0C091F",

            Divider = "#E8E8E3",
            DividerLight = "#0C0C09CC",
            LinesDefault = "#0C0C091F",
            LinesInputs = "#797978",
            TableLines = "#E8E8E3",
            TableStriped = "#0C0C0905",
            TableHover = "#0C0C090A",
            Skeleton = "#0C0C091C",

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
            Primary = "#006045",
            PrimaryContrastText = "#ECFDF5",
            PrimaryLighten = "#00BC7D",
            PrimaryDarken = "#003E2D",

            Secondary = "#27272A",
            SecondaryContrastText = "#FAFAFA",
            SecondaryLighten = "#525255",
            SecondaryDarken = "#1B1B1D",

            Tertiary = "#2B2B22",
            TertiaryContrastText = "#FBFBF9",
            TertiaryLighten = "#55554E",
            TertiaryDarken = "#1E1E18",

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

            Error = "#FF6467",
            ErrorContrastText = "#40191A",
            ErrorLighten = "#FF9395",
            ErrorDarken = "#8C3739",

            Black = "#27272F",
            White = "#FFFFFF",
            Dark = "#27272F",
            DarkContrastText = "#FFFFFF",
            DarkLighten = "#383843",
            DarkDarken = "#17171C",

            Background = "#0C0C09",
            BackgroundGray = "#2B2B22",
            Surface = "#1D1D16",
            AppbarBackground = "#1D1D16",
            AppbarText = "#FBFBF9",
            DrawerBackground = "#1D1D16",
            DrawerText = "#FBFBF9",
            DrawerIcon = "#FBFBF9",

            TextPrimary = "#FBFBF9",
            TextSecondary = "#ABAB9C",
            TextDisabled = "#FBFBF954",
            ActionDefault = "#ABAB9C",
            ActionDisabled = "#FBFBF942",
            ActionDisabledBackground = "#FBFBF91F",

            Divider = "#FFFFFF1A",
            DividerLight = "#FBFBF90F",
            LinesDefault = "#FBFBF91F",
            LinesInputs = "#FBFBF94D",
            TableLines = "#FFFFFF1A",
            TableStriped = "#FBFBF933",
            TableHover = "#FBFBF90A",
            Skeleton = "#FBFBF91C",

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
