export interface ISignUpForm {
  userName: string
  name: string // fullName TODO: sync fullName for be and fe
  email: string
  password: string
  confirmPassword: string
  acceptTerms: boolean
}
