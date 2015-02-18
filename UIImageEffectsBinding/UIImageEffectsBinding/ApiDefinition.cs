using System;
using ObjCRuntime;
using Foundation;
using UIKit;

namespace UIImageEffectsBinding {

	[Category, BaseType (typeof (UIImage))]
	public partial interface ImageEffects_UIImage {

        [Export ("applySubtleEffect")]
        UIImage ApplySubtleEffect();

        [Export ("applyLightEffect")]
        UIImage ApplyLightEffect();

        [Export ("applyExtraLightEffect")]
        UIImage ApplyExtraLightEffect();

        [Export ("applyDarkEffect")]
        UIImage ApplyDarkEffect();

		[Export ("applyTintEffectWithColor:")]
		UIImage ApplyTintEffectWithColor (UIColor tintColor);

		[Export ("applyBlurWithRadius:tintColor:saturationDeltaFactor:maskImage:")]
		UIImage ApplyBlurWithRadius (float blurRadius, UIColor tintColor, float saturationDeltaFactor, UIImage maskImage);
	}
}
