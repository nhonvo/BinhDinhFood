import { IProfile } from './Profile.types'

export interface IAuthSlice {
  isAuthenticated: boolean
}

export type TSignUpRequest = {
  email: string
  name: string
  userName: string
  password: string
}

export type TSignInRequest = {
  username: string
  password: string
}

// new
export type TAuthErrorResponse = {
  errorCode: string
  message: string
}

export interface TAuthResponse {
  userId: string
  token: string
  expires: string
}

export type TDecodedJWT = IProfile
