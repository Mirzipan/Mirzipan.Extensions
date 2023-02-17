using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mirzipan.Extensions.Unity.UI
{
    public static class ButtonExtensions
    {
        /// <summary>
        /// Sets the specified listener as the only listener of the OnClick event on this <see cref="Button"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="listener">OnClick callback</param>
        public static void SetOnClickListener(this Button @this, UnityAction listener)
        {
            @this.onClick.RemoveAllListeners();
            @this.onClick.AddListener(listener);
        }

        #region Colors

        /// <summary>
        /// Sets the <see cref="Color"/> of the <see cref="Graphic"/> of this <see cref="Button"/> if it exists.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="color">New graphic color</param>
        public static void SetGraphicColor(this Button @this, Color color)
        {
            if (!@this.targetGraphic)
            {
                return;
            }

            @this.targetGraphic.color = color;
        }

        /// <summary>
        /// Set the colors for this <see cref="Button"/> to the default values.
        /// </summary>
        /// <param name="this"></param>
        public static void ResetColors(this Button @this) => @this.colors = ColorBlock.defaultColorBlock;

        /// <summary>
        /// Set the normal <see cref="Color"/> for this <see cref="Button"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="color">Normal color</param>
        public static void SetNormalColor(this Button @this, Color color)
        {
            ColorBlock block = @this.colors;
            block.normalColor = color;
            @this.colors = block;
        }

        /// <summary>
        /// Set the highlighted <see cref="Color"/> for this <see cref="Button"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="color">Highlighted color</param>
        public static void SetHighlightedColor(this Button @this, Color color)
        {
            ColorBlock block = @this.colors;
            block.highlightedColor = color;
            @this.colors = block;
        }

        /// <summary>
        /// Set the pressed <see cref="Color"/> for this <see cref="Button"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="color">Pressed color</param>
        public static void SetPressedColor(this Button @this, Color color)
        {
            ColorBlock block = @this.colors;
            block.pressedColor = color;
            @this.colors = block;
        }

        /// <summary>
        /// Set the disabled <see cref="Color"/> for this <see cref="Button"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="color">Disabled color</param>
        public static void SetDisabledColor(this Button @this, Color color)
        {
            ColorBlock block = @this.colors;
            block.disabledColor = color;
            @this.colors = block;
        }

        #endregion Colors

        #region Sprites

        /// <summary>
        /// Sets the <see cref="Sprite"/> of the <see cref="Image"/> of this <see cref="Button"/> if the image exists.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="sprite">New sprite</param>
        public static void SetSprite(this Button @this, Sprite sprite)
        {
            if (@this.image)
            {
                @this.image.sprite = sprite;
            }
        }

        /// <summary>
        /// Sets the <see cref="Sprite"/> of the <see cref="Image"/> of this <see cref="Button"/> if the image exists.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="sprite">New sprite</param>
        /// <param name="color">New sprite color</param>
        public static void SetSprite(this Button @this, Sprite sprite, Color color)
        {
            if (!@this.image)
            {
                return;
            }

            @this.image.sprite = sprite;
            @this.image.color = color;
        }

        /// <summary>
        /// Set the selected <see cref="Sprite"/> for this <see cref="Button"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="sprite">Normal sprite</param>
        public static void SetSelectedSprite(this Button @this, Sprite sprite)
        {
            SpriteState block = @this.spriteState;
            block.selectedSprite = sprite;
            @this.spriteState = block;
        }

        /// <summary>
        /// Set the highlighted <see cref="Sprite"/> for this <see cref="Button"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="sprite">Normal sprite</param>
        public static void SetHighlightedSprite(this Button @this, Sprite sprite)
        {
            SpriteState block = @this.spriteState;
            block.highlightedSprite = sprite;
            @this.spriteState = block;
        }

        /// <summary>
        /// Set the pressed <see cref="Sprite"/> for this <see cref="Button"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="sprite">Normal sprite</param>
        public static void SetPressedSprite(this Button @this, Sprite sprite)
        {
            SpriteState block = @this.spriteState;
            block.pressedSprite = sprite;
            @this.spriteState = block;
        }

        /// <summary>
        /// Set the disabled <see cref="Sprite"/> for this <see cref="Button"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="sprite">Normal sprite</param>
        public static void SetDisabledSprite(this Button @this, Sprite sprite)
        {
            SpriteState block = @this.spriteState;
            block.disabledSprite = sprite;
            @this.spriteState = block;
        }

        #endregion Sprites
    }
}