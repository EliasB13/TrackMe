package com.eliasb.ark_android.model.dtos

import java.io.Serializable

data class AccountDataResponse(
    val id: Int,
    val login: String,
    val email: String,
    val companyName: String,
    val address: String,
    val phone: String,
    val description: String
) : Serializable