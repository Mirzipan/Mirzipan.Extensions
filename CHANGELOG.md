# Changelog

## [1.3.3] - 2023-03-15

### Added
- Colors and Colors32 with 141 predefined color values
- Color and Color32 extensions

## [1.3.2] - 2023-03-13

### Added
- OrderBy and ThenBy IEnumerable extensions with selectable direction
- Color32 extensions

### Changed
- IsZero for float and double now checks if number is smaller or equal to tolerance, instead of just smaller

## [1.3.1] - 2023-03-03

### Added
- Float and Double extensions for checking for zero and validity (not NaN and not infinity)
- MinObject and MaxObject enumerable extensions
- Byte extensions to allow using it as a bitmask

## [1.3.0] - 2023-02-19

### Added
- Even, Odd, and Every extensions for Enumerable
- Added more colors extensions (most notably PerceivedBrightness and VisibleTextColor)

### Removed
- All methods previously marked as Obsolete

## [1.2.3] - 2023-02-17

### Added
- Documentation for Collection, Dictionary, Enumerable, HashSet, and List extensions
- Documentation for Animator, Behaviour, Color, Component, GameObject, RectTransform, RichText, and Transform extensions
- Documentation for Button, CanvasGroup, Slider, and Toggle extensions
- Setters for sprites and colors for Button
- Setters for min and max values for Slider

### Fixed
- Incorrect check for index in Array and List IsIndexInRange()
- ForEach extensions (all variants) for IEnumerable not having deferred execution
- ForEach extensions (function variants) for IEnumerable not returning the correct type

## [1.2.2] - 2023-02-16

### Added
- Documentation for Boolean, Comparable, DateTime, Double, Float, Integer, Long, Object, and String extensions
- Collection extensions (Array, Collection)
- Unity types extensions (Vector2, Vector2Int, Vector3, Vector3Int, Bounds, BoundsInt, Rect, RectInt)

### Fixed
- Incorrect Deconstruct for BoundsInt

## [1.2.1] - 2023-02-13

### Added
- Float extensions
- Double extensions
- Int extensions
- String extensions
- Object extensions
- Collection extensions (Array, Dictionary, List, IEnumerable)
- Unity types extensions (Color, Vector2, Vector2Int, Vector3, Vector3Int, Vector4, Bounds, BoundsInt, Rect, RectInt)

## [1.2.0] - 2023-02-12

### Added
- Float extensions
- Double extensions
- Collection extensions (Array, Dictionary, List)
- CanvasGroup extensions

### Fixed
- Comparable IsBetweenExclusive check

### Changed
- Moved files between namespaces (UI, Math, etc)

## [1.1.3] - 2023-02-12

### Added
- Added methods for swizzle-like assignment (Vector2, Vector2Int, Vector3, Vector3Int)
- Added deconstruct (Vector2, Vector2Int, Vector3, Vector3Int, Vector4, Rect, RectInt, Bounds, BoundsInt)

## [1.1.2] - 2023-01-12

### Added
- Added roman numerals for int
- Added Vector3 -> Vector3 permutations
- Added Vector3Int -> Vector3Int permutations
- Added Vector4 -> Vector3 permutations

## [1.1.1] - 2023-01-05

### Fixed
- Added missing meta files

## [1.1.0] - 2023-01-05

### Added
- Unity type extensions (Color, Vector2, Vector2Int, Vector3, Vector3Int, Vector4)

### Changed
- Unity version bumped to 2021.3

## [1.0.2] - 2023-01-02

### Added
- StringBuilder conditional append

### Changed
- Updated namespaces in most files

## [1.0.1] - 2023-01-02

### Added
- Int extensions
- Collection extensions (Dictionary, Enumerable, List)
- Unity type extensions (Color, Rect, RectInt, Bounds, BoundsInt)
- Unity component extensions (GameObject, Component, Behaviour, Transform, Animator)

## [1.0.0] - 2022-12-03

### Added
- Basic type extensions (bool, object, string)
- Collection extensions (Array, Collection, Dictionary, Enumerable, HashSet)
- Comparable extensions
- DateTime extensions
- Unity TextMeshPro RichText tag extensions for string
- Unity type extensions (Color, RectInt)
- Unity component extensions (GameObject, Component, Transform)
- Unity ui component extensions (Button, Slider, Toggle)