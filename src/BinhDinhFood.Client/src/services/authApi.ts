import { createApi } from '@reduxjs/toolkit/query/react'
import { toast } from 'react-hot-toast'
import { baseQueryWithAuth } from './api'
import {
  TAuthErrorResponse,
  TAuthResponse,
  TSignInRequest,
  TSignUpRequest
} from '../shared/types/Auth.types'
import { IProfile } from '../shared/types/Profile.types'
import { setAuthStatus } from '../App/feature/auth/authSlice'
import { clearProfile } from '../App/feature/profile/profileSlice'

export const authApi = createApi({
  reducerPath: 'authApi',
  baseQuery: baseQueryWithAuth,
  endpoints: (build) => ({
    SignUp: build.mutation<
      TAuthErrorResponse,
      TSignUpRequest>({
        query({ userName, name, email, password }) {
          return {
            url: '/auth/register',
            method: 'POST',
            body: { userName, name, email, password },
          };
        }
      }),

    SignIn: build.mutation<
      TAuthResponse & { profile: IProfile } | TAuthErrorResponse,
      TSignInRequest
    >({
      query({ username, password }) {
        return {
          url: 'auth/login',
          method: 'POST',
          body: { username, password }
        }
      }
    }),
    SignOut: build.mutation<void, void>({
      query() {
        return {
          url: '/auth/logout',
          method: 'DELETE'
        }
      },
      async onQueryStarted(_, { dispatch, queryFulfilled }) {
        try {
          await queryFulfilled
          dispatch(setAuthStatus(false))
          dispatch(clearProfile())
          toast.success('You have successfully signed out')
        } catch (error: unknown) {
          toast.error('Sign out failed. Please try again later')
        }
      }
    })
  })
})

export const { useSignUpMutation, useSignInMutation, useSignOutMutation } =
  authApi
