# Mirzipan.Extensions

Collection of extension and utility methods I can created or collected over the years. Now they have a common place to live, to avoid having to copy them around or keep writing them all over again.

## C# Extensions

### Basic Types

#### Boolean
- Toggle
- ToString
- ToType

#### Object
- AsArray
- AsList
- AsHashSet
- AsDictionary
- Do
- DoIfNotNull
- Return
- Validate

#### String
- IsNullOrEmpty
- ValueOrDefault
- NullIfEmpty
- EmptyIfNull

### Complex Types

#### Comparable
- IsBetweenInclusive
- IsBetweenExclusive

#### DateTime
- IsBetween

### Collections

#### Array
- IsNullOrEmpty
- EmptyIfNull

#### Collection
- IsNullOrEmpty

#### Dictionary
- IsNullOrEmpty

#### Enumerable
- IsNullOrEmpty
- EmptyIfNull
- ToCountDictionary
- ToDictionary

#### HashSet
- AddRange
- AddRange

## Unity Extensions

### Basic Types

#### String
These are all RichText tags for use with TextMeshPro
- Colorize
- Bold
- Italic
- Underline
- Strikethrough
- Lowercase
- Uppercase
- Smallcaps
- Subscript
- Superscript
- Size
- LineHeight
- LineIndent
- Align

### Unity Types

#### Color
- Darken
- Lighten
- WithAlpha
- WithAlphaMultiplied
- WithRGBMultiplied

#### RectInt
- Encapsulate

### Basic Components

#### GameObject
- GetOrAddComponent

#### Component
- SetActive

#### Transform
- CopyPositionAndRotation
- SetPositionX
- SetPositionY
- SetPositionZ
- SetPositionXY
- SetPositionXZ
- SetPositionYZ

### UI

#### Button
- SetOnClickListener

#### Slider
- SetOnValueChangedListener

#### Toggle
- SetOnValueChangedListener