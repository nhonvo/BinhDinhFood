import { IProfile } from './Profile.types'

export interface IAuthSlice {
  isAuthenticated: boolean
}

export type TSignUpRequest = {
  email: string
  fullName: string
  password: string
}

export type TAuthResponseError = {
  status: number | string
  data: {
    error: boolean
    message: string
    field: [string]
  }
}

export type TSignInRequest = {
  username: string
  password: string
  rememberMe: boolean
}

export type TAuthErrorResponse = {
  errorCode: boolean
  message: string
}

export interface TAuthResponse {
  userId: string
  token: string
  expires: string
}


export type TDecodedJWT = IProfile
