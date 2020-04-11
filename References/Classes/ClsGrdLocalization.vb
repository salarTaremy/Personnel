Imports Telerik.WinControls.UI.Localization
Public Class ClsPersianRadGridLocalization
    Inherits RadGridLocalizationProvider
    Public Overrides Function GetLocalizedString(id As String) As String
        Select Case id
            Case RadGridStringId.ConditionalFormattingPleaseSelectValidCellValue
                Return "لطفا مقدار ستون های معتبر را انتخاب کنید"
            Case RadGridStringId.ConditionalFormattingPleaseSetValidCellValue
                Return "لطفا  مقدار معتبری برای ستون وارد کنید"
            Case RadGridStringId.ConditionalFormattingPleaseSetValidCellValues
                Return "لطفا  مقدار معتبری برای ستون وارد کنید"
            Case RadGridStringId.ConditionalFormattingPleaseSetValidExpression
                Return "لطفا مقدار معتبری را وارد کنید"
            Case RadGridStringId.ConditionalFormattingItem
                Return "مورد"
            Case RadGridStringId.ConditionalFormattingInvalidParameters
                Return "پارمتر نا معتبراست"
            Case RadGridStringId.FilterFunctionBetween
                Return "فی مابین دو عبارت باشد"
            Case RadGridStringId.FilterFunctionContains
                Return "شامل باشد"
            Case RadGridStringId.FilterFunctionDoesNotContain
                Return "شامل نباشد"
            Case RadGridStringId.FilterFunctionEndsWith
                Return "پایان یابد"
            Case RadGridStringId.FilterFunctionEqualTo
                Return "مساوی"
            Case RadGridStringId.FilterFunctionGreaterThan
                Return "بزرگتر باشد "
            Case RadGridStringId.FilterFunctionGreaterThanOrEqualTo
                Return "بزرگتر یا مساوی"
            Case RadGridStringId.FilterFunctionIsEmpty
                Return "خالی باشد"
            Case RadGridStringId.FilterFunctionIsNull
                Return "بدون داده (Null)"
            Case RadGridStringId.FilterFunctionLessThan
                Return "کوچکتر باشد"
            Case RadGridStringId.FilterFunctionLessThanOrEqualTo
                Return "کوچکتر یا مساوی"
            Case RadGridStringId.FilterFunctionNoFilter
                Return "بدون فیلتر"
            Case RadGridStringId.FilterFunctionNotBetween
                Return "فی مابین نباشد"
            Case RadGridStringId.FilterFunctionNotEqualTo
                Return "نا مساوی"
            Case RadGridStringId.FilterFunctionNotIsEmpty
                Return "خالی نباشد"
            Case RadGridStringId.FilterFunctionNotIsNull
                Return "بدون داده نباشد(IsNotNull)"
            Case RadGridStringId.FilterFunctionStartsWith
                Return "شروع شود "
            Case RadGridStringId.FilterFunctionCustom
                Return "پیشرفته"
            Case RadGridStringId.FilterOperatorBetween
                Return "بین"
            Case RadGridStringId.FilterOperatorContains
                'Return "شامل"
                Return Nothing
            Case RadGridStringId.FilterOperatorDoesNotContain
                Return "شامل نباشد"
            Case RadGridStringId.FilterOperatorEndsWith
                Return "پایان یابد"
            Case RadGridStringId.FilterOperatorEqualTo
                'Return "مساوی"
                Return Nothing
            Case RadGridStringId.FilterOperatorGreaterThan
                Return "بزرگتر"
            Case RadGridStringId.FilterOperatorGreaterThanOrEqualTo
                Return "بزرگتر مساوی"
            Case RadGridStringId.FilterOperatorIsEmpty
                Return "خالی"
            Case RadGridStringId.FilterOperatorIsNull
                Return "بدون داده(Null)"
            Case RadGridStringId.FilterOperatorLessThan
                Return "کوچکتر"
            Case RadGridStringId.FilterOperatorLessThanOrEqualTo
                Return "کوچکترمساوی"
            Case RadGridStringId.FilterOperatorNoFilter
                Return "بدون فیلتر"
            Case RadGridStringId.FilterOperatorNotBetween
                Return "بین نباشد"
            Case RadGridStringId.FilterOperatorNotEqualTo
                Return "نا مساوی"
            Case RadGridStringId.FilterOperatorNotIsEmpty
                Return "خالی نباشد"
            Case RadGridStringId.FilterOperatorNotIsNull
                Return "بدون داده نباشد"
            Case RadGridStringId.FilterOperatorStartsWith
                Return "شروع با"
            Case RadGridStringId.FilterOperatorIsLike
                Return "شبیه به"
            Case RadGridStringId.FilterOperatorNotIsLike
                Return "عدم تشابه"
            Case RadGridStringId.FilterOperatorIsContainedIn
                Return "موجود در"
            Case RadGridStringId.FilterOperatorNotIsContainedIn
                Return "موجود نباشد در"
            Case RadGridStringId.FilterOperatorCustom
                Return "پیشرفته"
            Case RadGridStringId.CustomFilterMenuItem
                Return "پیشرفته"
            Case RadGridStringId.CustomFilterDialogCaption
                Return " فیلترینگ پیشرفته  [{0}]"
            Case RadGridStringId.CustomFilterDialogLabel
                Return ":نمایش اطلاعات در صورتی که"
            Case RadGridStringId.CustomFilterDialogRbAnd
                Return "و"
            Case RadGridStringId.CustomFilterDialogRbOr
                Return "یا"
            Case RadGridStringId.CustomFilterDialogBtnOk
                Return "تایید"
            Case RadGridStringId.CustomFilterDialogBtnCancel
                Return "انصراف"
            Case RadGridStringId.CustomFilterDialogCheckBoxNot
                Return "فیلتر معکوس"
            Case RadGridStringId.CustomFilterDialogTrue
                Return "صحیح"
            Case RadGridStringId.CustomFilterDialogFalse
                Return "غلط"
            Case RadGridStringId.FilterMenuAvailableFilters
                Return "فیلترهای موجود"
            Case RadGridStringId.FilterMenuSearchBoxText
                Return "جستجو..."
            Case RadGridStringId.FilterMenuClearFilters
                Return "حذف فیلتر"
            Case RadGridStringId.FilterMenuButtonOK
                Return "تایید"
            Case RadGridStringId.FilterMenuButtonCancel
                Return "انصراف"
            Case RadGridStringId.FilterMenuSelectionAll
                Return "All"
            Case RadGridStringId.FilterMenuSelectionAllSearched
                Return "نتایج تمام جستجو ها"
            Case RadGridStringId.FilterMenuSelectionNull
                Return "خالی(NUll)"
            Case RadGridStringId.FilterMenuSelectionNotNull
                Return "خالی نیست(NotNull)"
            Case RadGridStringId.FilterFunctionSelectedDates
                Return "فیلتر بر اساس تاریخ خاص:"
            Case RadGridStringId.FilterFunctionToday
                Return "امروز"
            Case RadGridStringId.FilterFunctionYesterday
                Return "دیروز"
            Case RadGridStringId.FilterFunctionDuringLast7days
                Return "طی هفت روز گذشته"
            Case RadGridStringId.FilterLogicalOperatorAnd
                Return "و"
            Case RadGridStringId.FilterLogicalOperatorOr
                Return "یا"
            Case RadGridStringId.FilterCompositeNotOperator
                Return "معکوس"
            Case RadGridStringId.DeleteRowMenuItem
                Return "حذف ردیف"
            Case RadGridStringId.SortAscendingMenuItem
                Return "مرتب سازی صعودی"
            Case RadGridStringId.SortDescendingMenuItem
                Return "مرتب سازی نزولی"
            Case RadGridStringId.ClearSortingMenuItem
                Return "حذف مرتب سازی"
            Case RadGridStringId.ConditionalFormattingMenuItem
                Return "پیکربندی سفارشی "
            Case RadGridStringId.GroupByThisColumnMenuItem
                Return "گروه بندی این ستون"
            Case RadGridStringId.UngroupThisColumn
                Return "حذف گروه بندی این ستون"
            Case RadGridStringId.ColumnChooserMenuItem
                Return "انتخاب ستون"
            Case RadGridStringId.HideMenuItem
                Return "عدم نمایش ستون"
            Case RadGridStringId.HideGroupMenuItem
                Return "مخفی سازی گروه"
            Case RadGridStringId.UnpinMenuItem
                Return "غیرفعال"
            Case RadGridStringId.UnpinRowMenuItem
                Return "غیرفعال"
            Case RadGridStringId.PinMenuItem
                Return "علامت گذاری"
            Case RadGridStringId.PinAtLeftMenuItem
                Return "علامت گذاری در سمت چپ"
            Case RadGridStringId.PinAtRightMenuItem
                Return "علامت گذاری در سمت راست"
            Case RadGridStringId.PinAtBottomMenuItem
                Return "علامت گذاری در پایین"
            Case RadGridStringId.PinAtTopMenuItem
                Return "علامت گذاری در بالا"
            Case RadGridStringId.BestFitMenuItem
                Return "بهترین اندازه "
            Case RadGridStringId.PasteMenuItem
                Return "چسباندن"
            Case RadGridStringId.EditMenuItem
                Return "ویرایش"
            Case RadGridStringId.ClearValueMenuItem
                Return "حذف مورد"
            Case RadGridStringId.CopyMenuItem
                Return "کپی"
            Case RadGridStringId.CutMenuItem
                Return "برش"
            Case RadGridStringId.AddNewRowString
                Return "برای اضافه کردن ردیف جدید کلیک کنید"
                'Case RadGridStringId.SearchRowResultsOfLabel
                '    Return "of"
                'Case RadGridStringId.SearchRowMatchCase
                '    Return "Match case"
            Case RadGridStringId.ConditionalFormattingSortAlphabetically
                Return "مرتب سازی بر اساس حروف الفبا"
            Case RadGridStringId.ConditionalFormattingCaption
                Return "پیکربندی سفارشی رول منیجر"
            Case RadGridStringId.ConditionalFormattingLblColumn
                Return "پیکربندی ستون فقط توسط"
            Case RadGridStringId.ConditionalFormattingLblName
                Return "نام رول"
            Case RadGridStringId.ConditionalFormattingLblType
                Return "مقدار ستون"
            Case RadGridStringId.ConditionalFormattingLblValue1
                Return "مقدار 1"
            Case RadGridStringId.ConditionalFormattingLblValue2
                Return "مقدار 2"
            Case RadGridStringId.ConditionalFormattingGrpConditions
                Return "رول ها"
            Case RadGridStringId.ConditionalFormattingGrpProperties
                Return "مشخصات رول"
            Case RadGridStringId.ConditionalFormattingChkApplyToRow
                Return "اعمال این پیکربندی در کل ردیف"
            Case RadGridStringId.ConditionalFormattingChkApplyOnSelectedRows
                Return "اعمال این پیکربندی در صورتی که ردیف انتخاب شود"
            Case RadGridStringId.ConditionalFormattingBtnAdd
                Return "اضافه کردن رول جدید"
            Case RadGridStringId.ConditionalFormattingBtnRemove
                Return "حذف"
            Case RadGridStringId.ConditionalFormattingBtnOK
                Return "تایید"
            Case RadGridStringId.ConditionalFormattingBtnCancel
                Return "انصراف"
            Case RadGridStringId.ConditionalFormattingBtnApply
                Return "اعمال"
            Case RadGridStringId.ConditionalFormattingRuleAppliesOn
                Return "رول اعمال شود در"
            Case RadGridStringId.ConditionalFormattingCondition
                Return "انتخاب یک شرط"
            Case RadGridStringId.ConditionalFormattingExpression
                Return "فرمول"
            Case RadGridStringId.ConditionalFormattingChooseOne
                Return "[یکی را انتخاب کنید]"
            Case RadGridStringId.ConditionalFormattingEqualsTo
                Return "مساوی با [مقدار1]"
            Case RadGridStringId.ConditionalFormattingIsNotEqualTo
                Return "  نامساوی با  [مقدار1]"
            Case RadGridStringId.ConditionalFormattingStartsWith
                Return "شروع شود با  [مقدار1]"
            Case RadGridStringId.ConditionalFormattingEndsWith
                Return "خاتمه یابد با [مقدار1]"
            Case RadGridStringId.ConditionalFormattingContains
                Return "contains [مقدار1]"
            Case RadGridStringId.ConditionalFormattingDoesNotContain
                Return "does not contain [مقدار1]"
            Case RadGridStringId.ConditionalFormattingIsGreaterThan
                Return "is greater than [مقدار1]"
            Case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual
                Return "is greater than or equal [مقدار1]"
            Case RadGridStringId.ConditionalFormattingIsLessThan
                Return "is less than [مقدار1]"
            Case RadGridStringId.ConditionalFormattingIsLessThanOrEqual
                Return "is less than or equal to [مقدار1]"
            Case RadGridStringId.ConditionalFormattingIsBetween
                Return "is between [مقدار1] and [مقدار2]"
            Case RadGridStringId.ConditionalFormattingIsNotBetween
                Return "is not between [مقدار1] and [مقدار2]"
            Case RadGridStringId.ConditionalFormattingLblFormat
                Return "پیکربندی"
            Case RadGridStringId.ConditionalFormattingBtnExpression
                Return "Expression editor"
            Case RadGridStringId.ConditionalFormattingTextBoxExpression
                Return "Expression"
            Case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitive
                Return "CaseSensitive"
            Case RadGridStringId.ConditionalFormattingPropertyGridCellBackColor
                Return "CellBackColor"
            Case RadGridStringId.ConditionalFormattingPropertyGridCellForeColor
                Return "CellForeColor"
            Case RadGridStringId.ConditionalFormattingPropertyGridEnabled
                Return "Enabled"
            Case RadGridStringId.ConditionalFormattingPropertyGridRowBackColor
                Return "RowBackColor"
            Case RadGridStringId.ConditionalFormattingPropertyGridRowForeColor
                Return "RowForeColor"
            Case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignment
                Return "RowTextAlignment"
            Case RadGridStringId.ConditionalFormattingPropertyGridTextAlignment
                Return "TextAlignment"
            Case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitiveDescription
                Return "Determines whether case-sensitive comparisons will be made when evaluating string values."
            Case RadGridStringId.ConditionalFormattingPropertyGridCellBackColorDescription
                Return "Enter the background color to be used for the cell."
            Case RadGridStringId.ConditionalFormattingPropertyGridCellForeColorDescription
                Return "Enter the foreground color to be used for the cell."
            Case RadGridStringId.ConditionalFormattingPropertyGridEnabledDescription
                Return "Determines whether the condition is enabled (can be evaluated and applied)."
            Case RadGridStringId.ConditionalFormattingPropertyGridRowBackColorDescription
                Return "Enter the background color to be used for the entire row."
            Case RadGridStringId.ConditionalFormattingPropertyGridRowForeColorDescription
                Return "Enter the foreground color to be used for the entire row."
            Case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignmentDescription
                Return "Enter the alignment to be used for the cell values, when ApplyToRow is true."
            Case RadGridStringId.ConditionalFormattingPropertyGridTextAlignmentDescription
                Return "Enter the alignment to be used for the cell values."
            Case RadGridStringId.ColumnChooserFormCaption
                Return "Column Chooser"
            Case RadGridStringId.ColumnChooserFormMessage
                Return "Drag a column header from the" & vbLf & "grid here to remove it from" & vbLf & "the current view."
            Case RadGridStringId.GroupingPanelDefaultMessage
                Return "ستون مورد نظر جهت گروهبندی را انتخاب و اینجا رها کنید"
            Case RadGridStringId.GroupingPanelHeader
                Return "Group by:"
                'Case RadGridStringId.PagingPanelPagesLabel
                '    Return "Page"
                'Case RadGridStringId.PagingPanelOfPagesLabel
                '    Return "of"
            Case RadGridStringId.NoDataText
                Return "اطلاعاتی برای نمایش وجود ندرد"
            Case RadGridStringId.CompositeFilterFormErrorCaption
                Return "Filter Error"
            Case RadGridStringId.CompositeFilterFormInvalidFilter
                Return "The composite filter descriptor is not valid."
            Case RadGridStringId.ExpressionMenuItem
                Return "Expression"
            Case RadGridStringId.ExpressionFormTitle
                Return "Expression Builder"
            Case RadGridStringId.ExpressionFormFunctions
                Return "Functions"
            Case RadGridStringId.ExpressionFormFunctionsText
                Return "Text"
            Case RadGridStringId.ExpressionFormFunctionsAggregate
                Return "Aggregate"
            Case RadGridStringId.ExpressionFormFunctionsDateTime
                Return "Date-Time"
            Case RadGridStringId.ExpressionFormFunctionsLogical
                Return "Logical"
            Case RadGridStringId.ExpressionFormFunctionsMath
                Return "Math"
            Case RadGridStringId.ExpressionFormFunctionsOther
                Return "Other"
            Case RadGridStringId.ExpressionFormOperators
                Return "Operators"
            Case RadGridStringId.ExpressionFormConstants
                Return "Constants"
            Case RadGridStringId.ExpressionFormFields
                Return "Fields"
            Case RadGridStringId.ExpressionFormDescription
                Return "Description"
            Case RadGridStringId.ExpressionFormResultPreview
                Return "Result preview"
            Case RadGridStringId.ExpressionFormTooltipPlus
                Return "Plus"
            Case RadGridStringId.ExpressionFormTooltipMinus
                Return "Minus"
            Case RadGridStringId.ExpressionFormTooltipMultiply
                Return "Multiply"
            Case RadGridStringId.ExpressionFormTooltipDivide
                Return "Divide"
            Case RadGridStringId.ExpressionFormTooltipModulo
                Return "Modulo"
            Case RadGridStringId.ExpressionFormTooltipEqual
                Return "Equal"
            Case RadGridStringId.ExpressionFormTooltipNotEqual
                Return "Not Equal"
            Case RadGridStringId.ExpressionFormTooltipLess
                Return "Less"
            Case RadGridStringId.ExpressionFormTooltipLessOrEqual
                Return "Less Or Equal"
            Case RadGridStringId.ExpressionFormTooltipGreaterOrEqual
                Return "Greater Or Equal"
            Case RadGridStringId.ExpressionFormTooltipGreater
                Return "Greater"
            Case RadGridStringId.ExpressionFormTooltipAnd
                Return "منطقی ""و"""
            Case RadGridStringId.ExpressionFormTooltipOr
                Return "منطقی ""یا"""
            Case RadGridStringId.ExpressionFormTooltipNot
                Return "منطقی ""منفی"""
            Case RadGridStringId.ExpressionFormAndButton
                Return String.Empty
                'if empty, default button image is used
            Case RadGridStringId.ExpressionFormOrButton
                Return String.Empty
                'if empty, default button image is used
            Case RadGridStringId.ExpressionFormNotButton
                Return String.Empty
                'if empty, default button image is used
            Case RadGridStringId.ExpressionFormOKButton
                Return "تایید"
            Case RadGridStringId.ExpressionFormCancelButton
                Return "انصراف"
        End Select
        Return String.Empty
    End Function
End Class