Public Class Language
    Private arabic As String
    Private currencies As String
    Private czech As String
    Private danish As String
    Private dutch As String
    Private esperanto As String
    Private finnish As String
    Private french As String
    Private german As String
    Private greek As String
    Private hungarian As String
    Private icelandic As String
    Private italian As String
    Private maori As String
    Private mathLang As String
    Private norwegian As String
    Private polish As String
    Private portuguese As String
    Private romanian As String
    Private russian As String
    Private spanish As String
    Private swedish As String
    Private symbol As String
    Private turkish As String
    Private welsh As String

    Private langStr As String

    Public Sub New()
        arabic = "CHARACTERSETNOTINCLUDEDREMOVE"
        currencies = "$€¢£¥₩₪฿₫₴₹"
        czech = "úůýž'áčďéěíňóřšťÚŮÝŽÁČĎÉĚÍŇÓŘŠŤ"
        danish = "åæéøÅÆÉØ"
        dutch = "éëïóöüÉËÏÓÖÜ"
        esperanto = "ĉĝĥĵŝŭĈĜĤĴŜŬ"
        finnish = "äåöÄÅÖ"
        french = "ùûüÿ€àâæçéèêëïîôœÙÛÜŸÀÂÆÇÉÈÊËÏÎÔŒ"
        german = "äöüß€ÄÖÜ"
        greek = "άέήίϊΐόύϋΰώθωερτψυιοπασδφγηςκλζχξωβνμΆΈΉΊΪΐΌΎΫΰΏΘΩΕΡΤΨΥΙΟΠΑΣΔΦΓΗςΚΛΖΧΞΩΒΝΜ"
        hungarian = "áéíöóőüúűÁÉÍÖÓŐÜÚŰ"
        icelandic = "áæðéíóöþúýÁÆÐÉÍÓÖÞÚÝ"
        italian = "àèéìòóùÀÈÉÌÒÓÙ"
        maori = "āēīōūĀĒĪŌŪ"
        mathLang = "~∠½¼∕°‰øℂℕℙℚℝℤΓΔΛΞΠΣΦΨΩ∞∘∂∫∮∯∇̅⃗̇̈̂αβγδεζηθκλμνξπρστυφχψω∨∧¬⊕↑∀∃⇒⇔→↔∈⊂∉⊄⊆⊈⊃∪∩∖∅−±·×÷²³√∛′″‴∏∑≠≈≝≡≤≥≪≫ΑΒΓΕΖΗΘΚΛΜΝΞΠΡΣΤΥΦΧΨΩ"
        norwegian = "åæâéèêøóòôÅÆÂÉÈÊØÓÒÔ"
        polish = "ąćęłńóśźżĄĆĘŁŃÓŚŹŻ"
        portuguese = "ãáàâçéêíõóôúüÃÁÀÂÇÉÊÍÕÓÔÚÜ"
        romanian = "ăâîşșţțĂÂÎŞȘŢȚ"
        russian = "ёъяшертыуиопющэасдфгчйкльжзхцвбнмЁЪЯШЕРТЫУИОПЮЩЭАСДФГЧЙКЛЬЖЗХЦВБНМ"
        spanish = "áéíñóúüÁÉÍÑÓÚÜ¿¡"
        swedish = "äåéöÄÅÉÖ"
        symbol = "✓✗☐☑☒⏎⌘⌥★☆☀☼☁☂☃❄☽°′″‴µø‰←→↑↓↔↕⇄&amp;*#@©™®±−×÷·~≠≈≤≥½¼¾⅓⅔∕²³Δ∞☺☹❤́̀̈̂̃̆̄̌̇̊$€¢£¥•◦‣№§†‡⁂¶…“”‘’«»‹›✂☎✆✈✉✋✍✎♿⌖☯☢⚑♀♂♥♦♠♣♩♪♫♬♭♮♯▪■●◀▶▲▼▫□○◁▷△▽"
        turkish = "âçğıİîöşüûÂÇĞIİÎÖŞÜÛ"
        welsh = "ûüúùŵẅẃẁŷÿýỳâäáàêëéèîïíìôöóòÛÜÚÙŴẄẂẀŶŸÝỲÂÄÁÀÊËÉÈÎÏÍÌÔÖÓÒ"

        langStr = String.Empty
    End Sub

    Public Function getLanguages() As String
        Return langStr
    End Function

    Public Sub addLanguage(ByVal lang As String)
        langStr += lang
    End Sub

    Public Sub resetLanguage()
        langStr = String.Empty
    End Sub

    Public Function getArabic() As String
        Return arabic
    End Function

    Public Function getCurrencies() As String
        Return currencies
    End Function

    Public Function getCzech() As String
        Return czech
    End Function

    Public Function getDanish() As String
        Return danish
    End Function

    Public Function getDutch() As String
        Return dutch
    End Function

    Public Function getEsperanto() As String
        Return esperanto
    End Function

    Public Function getFinnish() As String
        Return finnish
    End Function

    Public Function getFrench() As String
        Return french
    End Function

    Public Function getGerman() As String
        Return german
    End Function

    Public Function getGreek() As String
        Return greek
    End Function

    Public Function getHungarian() As String
        Return hungarian
    End Function

    Public Function getIcelandic() As String
        Return icelandic
    End Function

    Public Function getItalian() As String
        Return italian
    End Function

    Public Function getMaori() As String
        Return maori
    End Function

    Public Function getMathLang() As String
        Return mathLang
    End Function

    Public Function getNorwegian() As String
        Return norwegian
    End Function

    Public Function getPolish() As String
        Return polish
    End Function

    Public Function getPortuguese() As String
        Return portuguese
    End Function

    Public Function getRomanian() As String
        Return romanian
    End Function

    Public Function getRussian() As String
        Return russian
    End Function

    Public Function getSpanish() As String
        Return spanish
    End Function

    Public Function getSwedish() As String
        Return swedish
    End Function

    Public Function getSymbol() As String
        Return symbol
    End Function

    Public Function getTurkish() As String
        Return turkish
    End Function

    Public Function getWelsh() As String
        Return welsh
    End Function
End Class
