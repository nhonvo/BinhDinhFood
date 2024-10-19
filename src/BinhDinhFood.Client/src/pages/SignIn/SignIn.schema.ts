import * as Yup from 'yup'

const SignInSchema = Yup.object().shape({
  username: Yup.string().required('UserName is required'),
  password: Yup.string()
    .required('Password is required')
    .min(6, 'Password is too short - should be 6 chars minimum')
})

export default SignInSchema
